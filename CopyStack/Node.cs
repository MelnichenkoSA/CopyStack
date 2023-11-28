using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CopyStack
{
    internal class Node
    {
        public dynamic Data { get; set; }
        public Node Next { get; set; }
        public int Index { get; set; }

        public Node(dynamic x)
        {
            Data = x;
            Next = null;
            Index = 0;
        }
    }
}
