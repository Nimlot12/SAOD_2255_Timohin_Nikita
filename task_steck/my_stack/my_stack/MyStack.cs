using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_stack
{
    internal class MyStack<T>
    {
        private T[] mas; 
        int count;
        int cap;
        public MyStack(int size)
        {
            mas = new T[size];
            cap = size;
        }
        public T[] ToArray()
        {
            T[] mas1 = new T[count];
            for(int i = 0; i < count; i++)
            {
                mas1[i] = mas[i];
            }
            return mas1;
        }

        public void Push(T push)
        {
            if(count == mas.Length)
            {
                throw new IndexOutOfRangeException();
            }
            mas[count++] = push;
        }
        public T Pop()
        {
            if (count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            return mas[--count];
        }
        public T Top()
        {
            if (count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            return mas[count-1];
        }
        public int Capacity()
        {
            return cap;
        }
    }
}
