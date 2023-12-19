using CopyStack.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyStack.Calculator
{
    internal abstract class ICalculatorCommand 
    {
        public abstract void Execute(LinkedListStack<double> stack);
    }
}
