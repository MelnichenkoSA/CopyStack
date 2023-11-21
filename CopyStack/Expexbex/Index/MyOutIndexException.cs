using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyStack.Expexbex.Index
{
    internal class MyOutIndexException : MyIndexException
    {
        public MyOutIndexException() : base()
        {

        }
        public MyOutIndexException(string Message) : base(Message)
        {

        }
    }
}
