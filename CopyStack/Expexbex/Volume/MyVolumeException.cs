using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyStack.Expexbex.Volume
{
    internal class MyVolumeException : Exception
    {
        public MyVolumeException() : base()
        {

        }
        public MyVolumeException(string Message) : base(Message)
        {

        }
    }
}
