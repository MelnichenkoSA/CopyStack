namespace CopyStack
{
    internal class LinkedListStack
    {
        private Node head;
        public int max;
        private int count;
        public int sum;

        public LinkedListStack(int n)
        {
            head = null;
            max = n;
            count = 0;
            sum = 0;
        }

        public void Push(int item)
        {
            if (count == max)
            {
                Console.WriteLine("Стек полон");
            }
            else
            {
                Node newNode = new Node(item);
                newNode.Next = head;
                head = newNode;
                newNode.Index = 0;
                GenerateIndex(head);

                count++;
                sum += item;
            }

        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Стек пуст");
                return default(int);
            }
            else
            {
                int data = head.Data;
                head = head.Next;
                head.Index = 0;
                GenerateIndex(head);
                sum -= data;
                return data;
            }
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Стек пуст");
                return default(int);
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
                Console.WriteLine("Стек пуст");
                return default(int);
            }

            return (sum / count);
        }

        public void GenerateIndex(Node head)
        {
            if (head.Next != null)
            {
                head.Next.Index = head.Index + 1;
                GenerateIndex(head.Next);
            }
        }
        public int FindIndex(int index, Node head)
        {
            if (!IsEmpty())
            {
                if (index == head.Index)
                {
                    return head.Data;
                }
                else
                {
                    FindIndex(index, head.Next);
                }

            }
            return default(int);
        }


        public LinkedListStack(LinkedListStack a, int n)
        {
            max = n;
            count = 0;

            Node current = a.head;
            Node copiedNode = null;


            while (current != null)
            {

                Node newNode = new Node(current.Data);


                if (copiedNode == null)
                {
                    this.head = newNode;
                }
                else
                {

                    copiedNode.Next = newNode;
                }


                copiedNode = newNode;
                current = current.Next;
            }
        }

        public int this[int index]
        {
            get
            {
                if (index < count)
                    return FindIndex(index, head);
                else
                    return default;
            }
        }

    }
}
