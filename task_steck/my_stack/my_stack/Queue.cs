using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_stack
{
    internal class Queue<T>
    {
        private T[] mas;
        public int count;
        private T[] _arr;
        private int _indOut;
        private int _indIn;
        private int _count;
        public Queue(int size)
        {
            mas = new T[size];
        }
        public void Enqueue(T val)
        {
            if (count == mas.Length)
            {
                throw new IndexOutOfRangeException();
            }
            mas[count++] = val;
        }
        public Dequeue()
        {
            if (count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            return mas[];
        }
        public Peek()
        {

        }
        public T[] ToArray()
        {
            T[] mas1 = new T[count];
            for (int i = 0; i < count; i++)
            {
                mas1[i] = mas[i];
            }
            return mas1;
        }
        public int Capacity()
        {
            return count;
        }

    }
}
