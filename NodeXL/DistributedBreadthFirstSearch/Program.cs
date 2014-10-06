using Smrf.NodeXL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributedBreadthFirstSearch
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

         static IVertex BreadthFirstSearch(IGraph graph, string searchKey, string searchValue)
         {
             Queue<IVertex> queue = new Queue<IVertex>();
             IVertex root = graph.Vertices.FirstOrDefault();
             Dictionary<IVertex, bool> visited = new Dictionary<IVertex, bool>();
             
             queue.Enqueue(root);
             visited[root] = true;

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
                     if (!visited.ContainsKey(child))
                     {
                         visited[child] = true;
                         queue.Enqueue(child);
                     }
                 }
             }

             return null;
         }
    }
}
