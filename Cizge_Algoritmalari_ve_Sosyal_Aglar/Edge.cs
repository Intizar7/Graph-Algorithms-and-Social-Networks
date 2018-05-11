using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cizge_Algoritmalari_ve_Sosyal_Aglar
{
    class Edge
    {
        public Node node;
        public int count;
        public string name;

        public Edge(Node node, int count, string name)
        {
            this.node = node;
            this.count = count;
            this.name = name;
        }

    }
}
