using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cizge_Algoritmalari_ve_Sosyal_Aglar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void Graph()
        {

        }
        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGenislikOncelikli_Click(object sender, EventArgs e)
        {

        }

        private void btnPrimAlgoritmasi_Click(object sender, EventArgs e)
        {

        }
       public void Dijksta(Graph graph, Node source)
        {
            graph.nodes.Find(node => node.Name == source.Name).distance = 0;
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
