using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyStack
{
    internal class SuperInt
    {
        public int front;
        public int back;
        public int left;
        public int right;

        public SuperInt(int front, int back,int left,int right) 
        {
            this.front = front;
            this.back = back;
            this.left = left;
            this.right = right;
        }

        public static bool operator >(SuperInt a, SuperInt b)
        {
            if (a.front + a.left + a.back + a.right > b.front + b.left + b.back + b.right)
                return true;
            else
                return false;
        }
        public static bool operator <(SuperInt a, SuperInt b)
        {
            if (a.front + a.left + a.back + a.right < b.front + b.left + b.back + b.right)
                return true;
            else
                return false;
        }
        public static bool operator ==(SuperInt a, SuperInt b)
        {
            if (a.front == b.front & a.left == b.left & a.back == b.back & a.right == b.right)
                return true;
            else
                return false;
        }
        public static bool operator !=(SuperInt a, SuperInt b)
        {
            if (a.front == b.front & a.left == b.left & a.back == b.back & a.right == b.right)
                return false;
            else
                return true;
        }
        ///////////////////////////////////////////////////////////////////

        public static bool operator >(SuperInt a, SuperBool b)
        {
            if ((a.front > b.super) || (a.back > b.super) || (a.left > b.super) || (a.right > b.super))
                return true;
            else
                return false;
        }
        public static bool operator <(SuperInt a, SuperBool b)
        {
            if ((a.front > b.super) || (a.back > b.super) || (a.left > b.super) || (a.right > b.super))
                return false;
            else
                return true;
        }
        public static bool operator ==(SuperInt a, SuperBool b)
        {
            if ((a.front == b.super) & (a.back == b.super) & (a.left == b.super) & (a.right == b.super))
                return true;
            else
                return false;
        }
        public static bool operator !=(SuperInt a, SuperBool b)
        {
            if ((a.front == b.super) & (a.back == b.super) & (a.left == b.super) & (a.right == b.super))
                return false;
            else
                return true;
        }
    }
}
