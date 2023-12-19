using CopyStack.Calculator;
using CopyStack.Expexbex.Data;
using CopyStack.Expexbex.Volume;
using CopyStack.Stack;

string infixExpression = "3 + 4 * 2 + 1";
string postfixExpression = InfixToPostfixConverter.ConvertToPostfix(infixExpression);
Console.WriteLine($"Infix Expression: {infixExpression}");
Console.WriteLine($"Postfix Expression: {postfixExpression}");

// Использование стекового калькулятора для вычисления постфиксного выражения
StackCalculator calculator = new StackCalculator();
double result = calculator.CalculatePostfixExpression(postfixExpression);

Console.WriteLine($"Result: {result}");


