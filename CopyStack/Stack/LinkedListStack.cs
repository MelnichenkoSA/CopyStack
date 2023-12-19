using CopyStack.Expexbex.Data;
using CopyStack.Expexbex.Index;
using CopyStack.Expexbex.Volume;
using System.Collections;

namespace CopyStack.Stack
{
    internal class LinkedListStack<T> : IEnumerable where T : IComparable<T>
    {
        public Node head;
        public int max;
        public int count;
        public dynamic sum;
        public int[] diapazon;
        public IEnumerator GetEnumerator() => new StackEnumerator<T>(this);

        public LinkedListStack(int n, int first, int end)
        {
            if (n <= 0)
                throw new MyVolumeException("Размер стэка должен быть больше 0");
            if (first > end)
                throw new MyDiapazonException("Диапазон задан неверно");
            head = null;
            max = n;
            count = 0;
            sum = 0;
            diapazon = new int[2];
            diapazon[0] = first;
            diapazon[1] = end;
        }

        public void Push(dynamic item)
        {
            if (diapazon[0] <= item)
            {
                if (diapazon[1] >= item)
                {
                    if (count == max)
                    {
                        throw new MyUpVolumeException("Stack is full");
                    }
                    else
                    {
                        Node newNode = new Node(item);
                        newNode.Next = head;
                        head = newNode;
                        newNode.Index = 0;
                        GenerateIndex(head);

                        count++;
                        sum = sum + item;
                    }
                }
                else
                    throw new MyUpOutDiapazonDataException("Число больше заданного диапазона");
            }
            else
                throw new MyDownOutDiapazonDataException("Число меньше заданного диапазона");

        }

        public dynamic Pop()
        {
            if (IsEmpty())
            {
                throw new MyDownVolumeException("Stack is empty");
            }
            else
            {
                dynamic data = head.Data;
                head = head.Next;
                if (head != null)
                {
                    head.Index = 0;
                    GenerateIndex(head);
                }
                sum -= data;
                return data;
            }
        }

        public dynamic Peek()
        {
            if (IsEmpty())
            {
                throw new MyDownVolumeException("Stack is empty");
            }

            return head.Data;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public int Sred()
        {
            if (IsEmpty())
            {
                throw new MyDownVolumeException("Stack is empty");
            }

            return sum / count;
        }

        public void GenerateIndex(Node head)
        {
            if (head.Next != null)
            {
                head.Next.Index = head.Index + 1;
                GenerateIndex(head.Next);
            }
        }
        public Node FindIndex(int index, Node head)
        {

            if (head != null)
            {
                if (index == head.Index)
                {
                    return head;
                }
                else
                {
                    return FindIndex(index, head.Next);
                }

            }
            else
                throw new MyDownVolumeException("Stack is empty");


        }
        public void SortSoft()
        {
            dynamic[] mas = new dynamic[count];
            for (int i = 0; i < count; i++)
            {
                mas[i] = this[i];
            }
            for (int i = 0; i < count; i++)
            {
                for (int j = 1; j < count; j++)
                {

                    if (mas[j].CompareTo(mas[j - 1]) == 1)
                    {
                        dynamic temp = mas[j];
                        mas[j] = mas[j - 1];
                        mas[j - 1] = temp;
                    }
                }
            }
            StringToMas(mas);
        }
        public void SortHard()
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = 1; j < count; j++)
                {
                    if (this[j].CompareTo(this[j - 1]) == 1)
                    {
                        dynamic temp = this[j];
                        this[j] = this[j - 1];
                        this[j - 1] = temp;
                    }
                }
            }
            StringTo();
        }
        public void StringToMas(dynamic[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
        }
        public void StringTo()
        {
            int c = 0;
            while (c < count)
            {
                Console.WriteLine("Извлечено: " + this[c]);
                c++;
            }
        }

        public LinkedListStack(LinkedListStack<T> a)
        {
            max = a.max;
            count = a.count;

            Node current = a.head;
            Node copiedNode = null;


            while (current != null)
            {

                Node newNode = new Node(current.Data);


                if (copiedNode == null)
                {
                    head = newNode;
                }
                else
                {

                    copiedNode.Next = newNode;
                }


                copiedNode = newNode;
                current = current.Next;
            }
        }

        public dynamic this[int index]
        {
            get
            {
                if (index < 0)
                    throw new MyDownOutIndexException("Индекс меньше допустимого");
                if (index >= count)
                    throw new MyUpOutIndexException("Индекс больше допустимого");
                return FindIndex(index, head).Data;
            }
            set
            {
                FindIndex(index, head).Data = value;
            }
        }

    }
}
