using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyStack.Expexbex.Index
{
    internal class MyDownOutIndexException : MyOutIndexException
    {
        public MyDownOutIndexException() : base()
        {

        }
        public MyDownOutIndexException(string Message) : base(Message)
        {

        }
    }
}
