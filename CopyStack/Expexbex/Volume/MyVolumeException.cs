﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopyStack.Stack;

namespace CopyStack.Expexbex.Volume
{
    internal class MyVolumeException : MyException
    {
        public MyVolumeException() : base()
        {

        }
        public MyVolumeException(string Message) : base(Message)
        {

        }
    }
}
