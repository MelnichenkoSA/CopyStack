using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CopyStack.Stack;

namespace CopyStack.Expexbex.Data
{
    internal class MyDataException : MyException
    {
        public MyDataException() : base()
        {

        }
        public MyDataException(string Message) : base(Message)
        {

        }


    }
}
