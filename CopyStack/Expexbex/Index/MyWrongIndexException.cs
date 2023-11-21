using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyStack.Expexbex.Index
{
    internal class MyWrongIndexException : MyIndexException
    {
        public MyWrongIndexException() : base()
        {

        }
        public MyWrongIndexException(string Message) : base(Message)
        {

        }
    }
}
