using CopyStack;
using CopyStack.Expexbex.Data;
using CopyStack.Expexbex.Volume;

try
{
    LinkedListStack stack = new LinkedListStack(5, 0, 5);

    stack.Push(1);
    stack.Push(2);
    stack.Push(3);
    stack.Push(4);
    stack.Push(5);

    Console.WriteLine("Среднее:" + stack.Sred());

    try
    {
        stack.Push(6);
    }
    catch (MyDownOutDiapazonDataException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (MyUpOutDiapazonDataException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (MyUpVolumeException ex)
    {
        Console.WriteLine(ex.Message);
    }



    try
    {
        Console.WriteLine("Искомый элемент: " + stack[2]);
    }
    catch (MyDownVolumeException ex)
    {
        Console.WriteLine(ex.Message);
    }

    try
    {
        Console.WriteLine("Вершина стека: " + stack.Peek());
    }
    catch (MyDownVolumeException ex)
    {
        Console.WriteLine(ex.Message);
    }

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

}
catch (MyVolumeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (MyDiapazonException ex)
{
    Console.WriteLine(ex.Message);
}


