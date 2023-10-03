using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if(count == max )
            {
                Console.WriteLine("Стек полон");
            }
            else
            {
                Node newNode = new Node(item);
                newNode.Next = head;
                head = newNode;
                count ++;
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

            int data = head.Data;
            head = head.Next;
            sum -= data;
            return data;
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


        public LinkedListStack (LinkedListStack a, int n)
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
    }
}
