﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyStack.Expexbex.Volume
{
    internal class MyUpVolumeException : MyVolumeException
    {
        public MyUpVolumeException() : base()
        {

        }
        public MyUpVolumeException(string Message) : base(Message)
        {

        }
    }
}
