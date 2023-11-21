using CopyStack;
using CopyStack.Expexbex.Data;
using CopyStack.Expexbex.Index;
using CopyStack.Expexbex.Volume;

LinkedListStack stack = new LinkedListStack(5);
try 
{
    Console.WriteLine("Искомый элемент: " + stack[2]); 
} 
catch (MyOutIndexException ex) 
{ 
    Console.WriteLine(ex.Message);
}
catch (MyDownVolumeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (MyWrongIndexException ex)
{
    Console.WriteLine(ex.Message);
}

stack.Pop();
stack.Sred();

try
{
    stack.Push("Привет");
}
catch (MyOutIndexException ex)
{
    Console.WriteLine(ex.Message);
}

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);




Console.WriteLine("Среднее:");
Console.WriteLine(stack.Sred());

try
{
    stack.Push(6);
}
catch (MyUpVolumeException ex)
{
    Console.WriteLine(ex.Message);
}

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




