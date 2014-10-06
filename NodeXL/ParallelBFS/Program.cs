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
