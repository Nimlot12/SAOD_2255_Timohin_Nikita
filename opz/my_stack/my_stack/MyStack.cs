using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_stack
{
    internal class OPZ
    {
        public string ToOPZ(string str)
        {
            MyStack<char> Stack = new MyStack<char>(10);
            Stack.Clear();//очистим стек
            string vivod = "";//строка для результата
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')//если скобка открытая то кидаем ее в стек и при этом топ увеличиваем на 1 (он уже не пустой)
                {
                    Stack.Push(str[i]);
                    continue;
                }
                if (str[i] == ')')
                {
                    while (Stack.isempty() == false)//если стек не пустой то
                    {
                        if (Stack.Top() == '(')// Top проверяет верхний элемент стека
                        {
                            Stack.Pop();
                            break;
                        }
                        vivod += Stack.Pop(); // pop передает верхний элемент и уменьшает  топ на 1
                    }
                    continue;
                }
                if ((str[i] >= '0') & (str[i] <= '9'))
                {
                    vivod = vivod + str[i];//если цифра то сразу в результат
                    continue;
                }
                while (true)
                {
                    if (str[i] == '+' || str[i] == '-' || str[i]== '*' || str[i] == '/' || str[i]=='^')
                    {
                        if (Stack.isempty() == true)
                        {
                            Stack.Push(str[i]);
                            break;
                        }
                        else
                        {
                            if (Stack.Priority(str[i]) < Stack.Priority(Stack.Top()))
                            {
                                vivod += Stack.Pop();
                                continue;
                            }
                            if (Stack.Priority(str[i]) >= Stack.Priority(Stack.Top()))
                            {
                                Stack.Push(str[i]);
                            }

                        }
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            while (Stack.isempty() == false)
            {
                if (Stack.Top() != '(') 
                    vivod += Stack.Pop();
            }
            return vivod;
        }
        public double PodschetRPN(string str)
        {
            Stack<double> st2 = new Stack<double>();
            st2.Clear();//очистим стек
                        

            for (int i = 0; i < str.Length; i++)//проверяем опз запись
            {
                //если число то кидаем в стек
                
                if (Char.IsDigit(str[i]))
                {
                    st2.Push(Convert.ToDouble(str[i].ToString()));

                    //if (str[i] == '0') st2.Push(0);
                    //if (str[i] == '1') st2.Push(1);
                    //if (str[i] == '2') st2.Push(2);
                    //if (str[i] == '3') st2.Push(3);
                    //if (str[i] == '4') st2.Push(4);
                    //if (str[i] == '5') st2.Push(5);
                    //if (str[i] == '6') st2.Push(6);
                    //if (str[i] == '7') st2.Push(7);
                    //if (str[i] == '8') st2.Push(8);
                    //if (str[i] == '9') st2.Push(9);
                }
                //если не цифра, а символ

                else
                {
                    //достаем из стека числа и записываем в переменные
                    double num1 = Convert.ToDouble(st2.Pop());
                    double num2 = Convert.ToDouble(st2.Pop());
                    //проводим вычисление
                    if (str[i] == '+')
                    {
                        st2.Push(num1 + num2);
                    }
                    if (str[i] == '-')
                    {
                        st2.Push(num2 - num1);
                    }
                    if (str[i] == '*')
                    {
                        st2.Push(num1 * num2);
                    }
                    if (str[i] == '/')
                    {
                        st2.Push(num2 / num1);
                    }
                    if (str[i] == '^')
                    {
                        st2.Push(Math.Pow(num1, num2));

                    }
                }
            }
            //3.По завершению обработки исходной строки в стеке содержится единственное число –
            //результат вычисления выражения.
            return st2.Pop();
        }

    }
     
    
    internal class MyStack<T>
    {
        private T[] mas; 
        public int count;
        int cap;
        public MyStack(int size)
        {
            mas = new T[size];
            cap = size;
        }
        public void Clear()
        {
            count = 0;
        }
        public bool isempty()
        {
            return (count == 0) ? true : false;
        }
        public int Priority(char Value)
        {
            if (Value == '(' || Value == ')') return 1;
            if (Value == '+' || Value == '-') return 2;
            if (Value == '*' || Value == '/') return 3;
            if (Value == '^') return 4;
            return 0;
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
            mas[count] = push;
            count++;
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
