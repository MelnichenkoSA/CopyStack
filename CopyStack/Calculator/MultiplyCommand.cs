using CopyStack.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyStack.Calculator
{
    internal class MultiplyCommand : ICalculatorCommand
    {
        public override void Execute(LinkedListStack<double> stack)
        {
            double operand2 = stack.Pop();
            double operand1 = stack.Pop();
            double result = operand1 * operand2;
            stack.Push(result);
        }
    }
}
