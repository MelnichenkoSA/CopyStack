using CopyStack.Expexbex.Data;
using CopyStack.Expexbex.Index;
using CopyStack.Expexbex.Volume;

namespace CopyStack
{
    internal class LinkedListStack
    {
        public Node head;
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
            string Item = Convert.ToString(item);
            if (int.TryParse(Item, out count))
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
                    sum += item;
                }
            }
            else
                throw new MyWrongDataException("Wrong Data");

        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new MyDownVolumeException("Stack is empty");
            }
            else
            {
                int data = head.Data;
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

        public int Peek()
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
        public int FindIndex(string Index, Node head)
        {
            string Indexstr = Index;
            if (int.TryParse(Indexstr, out int index))
            {
                if (head != null)
                {
                    if (index == head.Index)
                    {
                        return head.Data;
                    }
                    else
                    {
                        if (head != null)
                            return FindIndex(Index, head.Next);
                        else
                            throw new MyOutIndexException("Wrong Index");
                    }

                }
                else
                    throw new MyDownVolumeException("Stack is empty");
            }
            else
                throw new MyWrongIndexException();

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
                string Index = Convert.ToString(index);
                return FindIndex(Index, head);
            }
        }

    }
}
