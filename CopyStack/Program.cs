using CopyStack;
using CopyStack.Expexbex.Data;
using CopyStack.Expexbex.Volume;

try
{
    LinkedListStack<SuperBool> stack = new LinkedListStack<SuperBool>(5, 0, 11);
    LinkedListStack<int> stack1 = new LinkedListStack<int>(5, 0, 11);
    stack1.Push(1);
    stack1.Push(7);
    stack1.Push(3);
    stack1.Push(4);

    stack1.SortSoft();

    SuperBool sus = new SuperBool(true, false);
    SuperBool esus = new SuperBool(false, true);
    SuperBool ses = new SuperBool(true, true);
    SuperBool uses = new SuperBool(false, false);

    stack.Push(sus);
    stack.Push(esus);
    stack.Push(ses);
    stack.Push(uses);

    stack.SortSoft();

    foreach (var data in stack)
    {
        Console.WriteLine(data.ToString());
    }

    stack.SortHard();



    /*stack.Push(1);
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
    }*/


}
catch (MyVolumeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (MyDiapazonException ex)
{
    Console.WriteLine(ex.Message);
}


