using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyStack.Calculator
{
    internal class InfixToPostfixConverter
    {
        private static int GetPriority(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
                default:
                    return 0; // для чисел
            }
        }

        public static string ConvertToPostfix(string infixExpression)
        {
            StringBuilder postfixExpression = new StringBuilder();
            Stack<char> operatorStack = new Stack<char>();

            try
            {
                foreach (char token in infixExpression)
                {
                    if (char.IsDigit(token))
                    {
                        postfixExpression.Append(token);
                    }
                    else if (token == '(')
                    {
                        operatorStack.Push(token);
                    }
                    else if (token == ')')
                    {
                        while (operatorStack.Count > 0 && operatorStack.Peek() != '(')
                        {
                            postfixExpression.Append(operatorStack.Pop());
                        }

                        if (operatorStack.Count == 0)
                        {
                            throw new CalculatorException("Mismatched parentheses in infix expression.");
                        }

                        // Удаляем открывающую скобку из стека
                        operatorStack.Pop();
                    }
                    else
                    {
                        while (operatorStack.Count > 0 && GetPriority(operatorStack.Peek()) >= GetPriority(token))
                        {
                            postfixExpression.Append(operatorStack.Pop());
                        }

                        operatorStack.Push(token);
                    }
                }

                while (operatorStack.Count > 0)
                {
                    char stackTop = operatorStack.Pop();
                    if (stackTop == '(')
                    {
                        throw new CalculatorException("Mismatched parentheses in infix expression.");
                    }

                    postfixExpression.Append(stackTop);
                }
            }
            catch (InvalidOperationException)
            {
                throw new CalculatorException("Invalid infix expression.");
            }

            return postfixExpression.ToString();
        }
    }
}
