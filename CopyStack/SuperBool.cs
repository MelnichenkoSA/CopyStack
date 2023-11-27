using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CopyStack
{
    internal class SuperBool : IComparable<SuperBool>
    {
        public bool front;
        public bool back;
        public int super;

        public SuperBool(bool front, bool back)
        { 
            Random rnd = new Random();
            this.front = front;
            this.back = back;
            super = rnd.Next(11);
        }

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
        ///////////////////////////////////////////////////////////////////
        public static bool operator >(SuperBool a, SuperBool b)
        {
            if (a.super > b.super)
                if (a.front == b.front)
                    return true;
                else 
                    return false;
            else
                return false;
        }
        public static bool operator <(SuperBool a, SuperBool b)
        {
            if (a.super < b.super)
                if (a.front == b.front)
                    return true; 
                else
                    return false;
            else
                return true;
        }
        public static bool operator ==(SuperBool a, SuperBool b)
        {
            if (a.super == b.super)
                if (a.front == b.front)
                    return true;
                else 
                    return false;
            else
                return false;
        }
        public static bool operator !=(SuperBool a, SuperBool b)
        {
            if (a.super == b.super)
                if (a.front == b.front)
                    return false;
                else
                    return true;
            else
                return true;
        }
        public int CompareTo(SuperBool? person)
        {
            if (person is null) throw new ArgumentException("Некорректное значение параметра");
            return super.CompareTo(person.super);
        }
    }
}
