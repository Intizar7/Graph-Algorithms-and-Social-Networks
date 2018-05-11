using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cizge_Algoritmalari_ve_Sosyal_Aglar
{
   public class Dijksta
    {
       
        public Dijksta() { }

        public void Dijksta(Node source, Graph graph)
        {
            graph.nodes.Find(Node => Node.Name == source.Name).distance = 0;
            PriorityQueue priority = new PriorityQueue();
            priority.Enqueue(graph.nodes);
            while (priority.list.Count > 0)
            {
                Node node = priority.Dequeue();
                foreach (Edge edge in node.neighbour)
                {
                    Node adjacent = edge.node;
                    int cost = edge.count + node.distance;
                    if (cost < adjacent.distance)
                    {
                        adjacent.distance = cost;
                        adjacent.path = string.Empty;
                        if (!string.IsNullOrEmpty(node.path))
                            adjacent.path += node.path;
                        adjacent.path += edge.name + ";";
                        priority.Update(node);
                    }
                }
            }
        }
       
       
    }
}
