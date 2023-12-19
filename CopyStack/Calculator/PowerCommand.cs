using CopyStack.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyStack.Calculator
{
    internal class PowerCommand : ICalculatorCommand
    {
        public override void Execute(LinkedListStack<double> stack)
        {
            double exponent = stack.Pop();
            double baseValue = stack.Pop();
            double result = Math.Pow(baseValue, exponent);
            stack.Push(result);
        }
    }
}
