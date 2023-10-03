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

        public LinkedListStack()
        {
            head = null;
        }

        public void Push(int item)
        {
            Node newNode = new Node(item);
            newNode.Next = head;
            head = newNode;
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

        public LinkedListStack Copy()
        {
            LinkedListStack copyStack = new LinkedListStack();


            Node current = head;
            Node copiedNode = null;


            while (current != null)
            {

                Node newNode = new Node(current.Data);


                if (copiedNode == null)
                {
                    copyStack.head = newNode;
                }
                else
                {

                    copiedNode.Next = newNode;
                }


                copiedNode = newNode;
                current = current.Next;
            }

            return copyStack;
        }
    }
}
