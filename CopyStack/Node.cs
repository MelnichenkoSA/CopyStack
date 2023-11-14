using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyStack
{
    internal class Node
    {
        public int Data { get; }
        public Node Next { get; set; }
        public int Index { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
            Index = 0;
        }
    }
}
