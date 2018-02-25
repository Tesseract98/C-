using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic__обобщения_
{
    class Program
    {

        static void Swap<T>(ref T a, ref T b) // ref передача аргументов по ссылке, чтобы изменять <U,V>
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Out(out int a) // out значение в главной функции не определенно 
        {
            a = 7;
        }

        class Stack<T>
        {
            public Stack(int na)
            {
                n = na;
                innerArray = new T[n];
            }
            static int n;
            int index = 0;
            T[] innerArray;
            public void Push(T item)
            {
                try
                {
                    innerArray[index++] = item;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Stack is overflow");
                }
            }
            public T Pop()
            {
                if (index > n)
                    index = n;
                if (index - 1 < 0)
                    index = 1;
                return innerArray[--index];
            }
            public T Get(int k)
            {
                return innerArray[k];
            }
        }

        static void Main(string[] args)
        {
            #region Out Swap
            /*
            int a;
            Out(out a);
            Console.WriteLine("Out: {0}", a);
            int c, b;
            Console.Write("c = ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Swap<int>(ref c, ref b);
            Console.WriteLine("c = {0} \t b = {1}", c, b); // {0,5} 5 - кол-во отступов
            string s1 = "Hello";
            string s2 = "World";
            Swap<string>(ref s1, ref s2);
            Console.WriteLine(s1 + " " + s2);
            */
            #endregion
            #region Stack
            /*
            Stack<int>s = new Stack<int>(2);
            s.Push(1);
            s.Push(2);
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            */
            #endregion

            Console.ReadKey();
        }
    }
}
