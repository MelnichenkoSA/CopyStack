using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyStack.Expexbex.Index
{
    internal class MyUpOutIndexException : MyOutIndexException
    {
        public MyUpOutIndexException() : base()
        {

        }
        public MyUpOutIndexException(string Message) : base(Message)
        {

        }
    }
}
