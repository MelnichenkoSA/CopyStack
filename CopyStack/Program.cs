using CopyStack;

LinkedListStack stack = new LinkedListStack();

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);

Console.WriteLine("Вершина стека: " + stack.Peek());

LinkedListStack copyStack = stack.Copy();

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
