using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cizge_Algoritmalari_ve_Sosyal_Aglar
{
    class Node
    {
        //node 'un adi ve mesleği tanımlanması
        public string Name { get; set; }
        public string Job { get; set; }
        //kenara olan uzaklık
        public int distance;
        //kenar komşuların listesi
        public List<Edge> neighbour = new List<Edge>();

        public string path = string.Empty;
        //constracture oluşturulması
        public Node(string Name , string Job)
        {
            this.Name = Name;
            this.Job = Job;
        }
    }
}
