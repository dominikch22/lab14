using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    class Trojka<T> where T : IComparable<T>
    {
        private T a, b, c;
        private T[] values;

        public Trojka(T valueA, T valueB, T valueC)
        {
            a = valueA;
            b = valueB;
            c = valueC;
            T[] values = { a, b, c };
            this.values = values;
        }

        public T A
        {
            get { return a; }
            set { a = value; }
        }

        public T B
        {
            get { return b; }
            set { b = value; }
        }

        public T C
        {
            get { return c; }
            set { c = value; }
        }

        public override string ToString()
        {
            return $"({a}, {b}, {c})";
        }

        public string GetSortedString()
        {
            return $"{values[0]}, {values[1]}, {values[2]}";
        }

        public T this[int index]
        {
            get
            {
                return values[index];             
            }
        }

        public void Sort()
        {
            Array.Sort(values);          
        }
    }
}
