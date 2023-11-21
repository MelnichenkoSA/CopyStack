using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyStack.Expexbex.Data
{
    internal class MyDiapazonException : MyDataException
    {
        public MyDiapazonException() : base() { }
        public MyDiapazonException(string message) : base(message) { } 
    }
}
