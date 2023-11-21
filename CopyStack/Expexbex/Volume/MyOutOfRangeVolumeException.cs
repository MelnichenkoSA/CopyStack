using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyStack.Expexbex.Volume
{
    internal class MyOutOfRangeVolumeException : MyVolumeException
    {
        public MyOutOfRangeVolumeException(string Message) : base(Message) { }
    }
}
