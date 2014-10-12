using System;
using Smrf.NodeXL.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelBFS
{
    class Program
    {
        const int NUM_THREADS = 8;
        [STAThread]
        static void Main(string[] args)
        {
            GraphGenerator graphGenerator = new GraphGenerator();
            IGraph graph = graphGenerator.Generator();

            String[] metadataCollection = graph.GetRequiredValue(ReservedMetadataKeys.AllVertexMetadataKeys, typeof(String[])) as String[];
            List<string> vertexExampleValues = new List<string>();

            foreach (var metadata in metadataCollection)
            {
                IVertex vertex = graph.Vertices.FirstOrDefault();
                if (vertex.GetValue(metadata) != null)
                {
                    vertexExampleValues.Add(vertex.GetValue(metadata).ToString());
                }
            }

            var ShowTheExamples = vertexExampleValues;

            IVertex discoveredVertex = BreadthFirstSearch(graph, "Last Name", "Pecoraro");
            if (discoveredVertex != null)
            {
                string firstName = discoveredVertex.GetValue("First Name").ToString();
                string lastName = discoveredVertex.GetValue("Last Name").ToString();
            }
            BreadthFirstSearch(graph, "name", "James Ihrig");
        }

        
        static void OneDimensionalPartitioning(IGraph g)
        {
            //Divide graph into portions and call
            //threads on BFSOnOneDimensionalPartitioning();
            int graphSize = g.Vertices.Count();
            int numSubgraphVertices = graphSize / NUM_THREADS;
            for ( int i = 0; i < NUM_THREADS; i++ )
            {
                int remainder = graphSize % NUM_THREADS;
                List<IVertex> threadVertices = new List<IVertex>();

                int startIndex = i * numSubgraphVertices;

                List<IVertex> graphAsList = g.Vertices.Cast<IVertex>().ToList();
               
                if (i == NUM_THREADS - 1)
                {
                    numSubgraphVertices += remainder;
                }

                List<IVertex> subGraph = graphAsList.GetRange(startIndex, numSubgraphVertices);
                BFSOnOneDimensionalPartitioning(subGraph);
            }
        }
        
        //static void BFSOnOneDimensionalPartitioning(IGraph subGraph)
        static void BFSOnOneDimensionalPartitioning(List<IVertex> subGraph)
        {
            // L = level of vertices serched

            //Lva = (L sub (v sub s))
            //                     / 0, v = (v sub s), where (v sub s) is a source
            //1: Initilize Lva(v) <
            //                     \ inf, otherwise
            // 2: for l = 0 to inf do
            // 3:   F <- {v|Lva(v) = l}, the set of all local vertices with level l
            // 4:   if F = null for all processors then
            // 5:       Terminate main loop
            // 6:   end if
            // 7:   N <- {neighbors of vertices in f (not neccessarily local
            // 8:   for all processors q do
            // 9:       Nq <- { vertices in N owned by processor q}
            //10:       Send Nq to processor q
            //11:       Receive N`q from processor q
            //12:   end for
            //13:   N` <- Uq N'q ( Ther N`q may overlap)
            //14:   for v elementOf N` and Lvs(v) = inf do
            //15:       Lvs(v) <- l + 1
            //16:   endfor
            //17: end for

            UInt32 currentLevel = 0;
            IVertex root = subGraph.FirstOrDefault();
            root.Visited = true;
            root.Level = currentLevel;

            for (currentLevel = 0; currentLevel < UInt32.MaxValue; currentLevel++ )
            {
                foreach (IEdge e in root.OutgoingEdges)
                {
                    IVertex currentVertex = e.Vertex2;
                    List<IVertex> F = new List<IVertex>();
                    if ( !currentVertex.Visited )
                    {
                        F.Add(currentVertex);
                    }
                    if ( F.Count == 0 )
                    {
                        return;
                    }
                    List<IVertex> N = new List<IVertex>();
                    //for ()
                    //for ( uint i = 0; i < NUM_THREADS;  )
                    {

                    }
                        currentLevel++;
                    IVertex v = e.Vertex2;
                    v.Level = currentLevel;
                    v.Visited = true;
                    //v.Lev
                }
            }
        }


        static Smrf.NodeXL.Core.IVertex BreadthFirstSearch(IGraph graph, string searchKey, string searchValue)
        {
            Queue<IVertex> queue = new Queue<IVertex>();
            IVertex root = graph.Vertices.FirstOrDefault();

            queue.Enqueue(root);
            root.Visited = true;

            while (queue.Count > 0)
            {
                IVertex currentNode = queue.Dequeue();

                string val = currentNode.GetValue(searchKey).ToString();
                if (currentNode.GetValue(searchKey).ToString() == searchValue)
                {
                    return currentNode;
                }

                foreach (IEdge edge in currentNode.IncidentEdges)
                {
                    IVertex child = edge.Vertex2;
                    if (!child.Visited)
                    {
                        queue.Enqueue(child);
                        child.Visited = true;
                    }
                }
            }

            return null;
        }
    }
}
