using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyStack.Stack
{
    internal class StackEnumerator<T> : IEnumerator where T : IComparable<T>
    {
        int pos = -1;
        LinkedListStack<T> stack;
        public StackEnumerator(LinkedListStack<T> stack)
        {
            this.stack = stack;
        }
        public object Current
        {
            get
            {
                if (pos == -1 || pos >= stack.count)
                    throw new ArgumentException();
                return stack[pos];
            }
        }
        public bool MoveNext()
        {
            if (pos < stack.count - 1)
            {
                pos++;
                return true;
            }
            else
                return false;
        }
        public void Reset() => pos = -1;
    }
}
