using CopyStack.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyStack.Calculator
{
    internal class StackCalculator
    {
        private LinkedListStack<double> operandStack;
        private List<ICalculatorCommand> commands;

        public StackCalculator()
        {
            operandStack = new LinkedListStack<double>(100,-10000,10000);
            commands = new List<ICalculatorCommand>();
        }
        public double CalculateInfixExpression(string infixExpression)
        {
            string postfixExpression = ConvertToPostfix(infixExpression);
            return CalculatePostfixExpression(postfixExpression);
        }
        public double CalculatePostfixExpression(string postfixExpression)
        {
            string[] tokens = postfixExpression.Split(' ');

            foreach (var token in tokens)
            {
                if (!string.IsNullOrWhiteSpace(token))
                {
                    if (double.TryParse(token, out double operand))
                    {
                        operandStack.Push(operand);
                    }
                    else if (token.Length == 1 && "+-*/".Contains(token))
                    {
                        ICalculatorCommand command = CommandFactory.CreateCommand(token[0]);
                        command.Execute(operandStack);
                    }
                    else
                    {
                        throw new CalculatorException($"Invalid token '{token}' in postfix expression.");
                    }
                }
            }

            return GetResult();
        }

        private double GetResult()
        {
            if (operandStack.IsEmpty())
            {
                throw new CalculatorException("Expression is empty.");
            }

            return operandStack.Pop();
        }
        // Метод для преобразования в постфиксную запись
        private string ConvertToPostfix(string infixExpression)
        {
            StringBuilder postfix = new StringBuilder();
            Stack<char> operators = new Stack<char>();

            foreach (char symbol in infixExpression)
            {
                if (char.IsDigit(symbol) || symbol == '.')
                {
                    postfix.Append(symbol); // Если символ - цифра или точка, добавляем к постфиксной записи
                }
                else if ("+-*/".Contains(symbol))
                {
                    postfix.Append(' '); // Разделяем операторы пробелами
                    while (operators.Count > 0 && Priority(operators.Peek()) >= Priority(symbol))
                    {
                        postfix.Append(operators.Pop()).Append(' '); // Перенос операторов из стека в постфиксную запись
                    }
                    operators.Push(symbol); // Помещаем текущий оператор в стек
                }
                else if (symbol == '(')
                {
                    operators.Push(symbol); // Открывающую скобку помещаем в стек
                }
                else if (symbol == ')')
                {
                    postfix.Append(' ');
                    while (operators.Count > 0 && operators.Peek() != '(')
                    {
                        postfix.Append(operators.Pop()).Append(' '); // Перенос операторов из стека в постфиксную запись до открывающей скобки
                    }
                    operators.Pop(); // Убираем открывающую скобку из стека
                }
            }

            while (operators.Count > 0)
            {
                postfix.Append(' ').Append(operators.Pop()).Append(' '); // Перенос оставшихся операторов в постфиксную запись
            }

            return postfix.ToString().Trim();
        }

        // Вспомогательный метод для определения приоритета оператора
        private int Priority(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                default:
                    return 0;
            }
        }

    }
}
