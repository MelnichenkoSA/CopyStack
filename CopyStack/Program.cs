using CopyStack;

LinkedListStack stack = new LinkedListStack(5);
stack.Pop();

stack.Sred();

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);

Console.WriteLine("Среднее:");
Console.WriteLine(stack.Sred());

stack.Push(6);
Console.WriteLine("Вершина стека: " + stack.Peek());

LinkedListStack copyStack = new LinkedListStack(stack, stack.max);

Console.WriteLine("Стэк:");
while (!stack.IsEmpty())
{
    Console.WriteLine("Извлечено: " + stack.Pop());
}

Console.WriteLine("Копия Стэка:");
while (!copyStack.IsEmpty())
{
    Console.WriteLine("Извлечено: " + copyStack.Pop());
}
