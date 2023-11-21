using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyStack.Expexbex.Data
{
    internal class MyWrongDataException : MyDataException
    {
        public MyWrongDataException() : base() { }
        public MyWrongDataException(string message) : base(message) { } 
    }
}
