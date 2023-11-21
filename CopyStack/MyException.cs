using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyStack
{
    internal class MyException : Exception
    {
        public MyException() : base ()
        {
        
        }
        public MyException(string Message) : base(Message)
        {

        }
    }
}
