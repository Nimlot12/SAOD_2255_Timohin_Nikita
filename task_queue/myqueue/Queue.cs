using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myqueue
{
    internal class Queue<T>
    {
        private T[] arr;
        public int Capacity
        {
            get;
        }
        public Queue(int size)
        {
            arr = new T[size];
            Capacity = arr.Length;
        }
        private int Tail;
        private int Head; 
        public int count;

        public void Enqueue(T value)
        {
            if (count != arr.Length)
            {
                arr[Head] = value;
                Head++;
                if (Head == arr.Length)
                {
                    Head = 0;
                }
                count++;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public T Dequeue()
        {
            if (count > 0)
            {
                T value = arr[Tail];
                Tail++;
                if (Tail == arr.Length)
                {
                    Tail = 0;
                }
                count--;
                return value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public T Peek()
        {
            if (count > 0)
            {
                return arr[Tail];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public T[] ToArray()
        {
            T[] res = new T[count];
            int fori = count;
            int index = Tail;
            int i = 0;
            while (fori != 0)
            {
                res[i] = arr[index];
                index++;
                if(index == arr.Length) 
                {
                    index = 0;

                }
                fori--;
                i++;
            }
            return res;
        }
    }
}
