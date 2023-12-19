using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyStack.Calculator
{
    internal class CommandFactory
    {
        public static ICalculatorCommand CreateCommand(char operatorSymbol)
        {
            switch (operatorSymbol)
            {
                case '+':
                    return new AddCommand();
                case '-':
                    return new SubtractCommand();
                case '*':
                    return new MultiplyCommand();
                case '/':
                    return new DivideCommand();
                case '^':
                    return new PowerCommand();
                default:
                    throw new CalculatorException("Unknown operator.");
            }
        }
    }
}
