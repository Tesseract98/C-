using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интерфейсы
{

    interface IsomeInterface // нельзя употреблять модификаторы доступа
    {
        int property { get; set; }
        void Print();
    }

    interface IDraw
    {
        void Draw();
    }

    class Test : IsomeInterface, IDraw  // множественное наследование возможно только для интерфейсов
    {
        public int property { get; set; }
        public void Print()
        {
            Console.WriteLine("Some text");
        }
        public void Draw()
        {
            Console.WriteLine("Draw method");
        }
    }

    class Test_2 : IsomeInterface
    {
        public int property { get; set; }
        public void Print()
        {
            Console.WriteLine("Text 2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            Test_2 t2 = new Test_2();
            t1.property = 12;
            t1.Print();
            Console.WriteLine(t1.property);
            t1.Draw();

            Console.WriteLine();

            t2.property = 15;
            t2.Print();
            Console.WriteLine(t2.property);

            Console.ReadKey();
        }
    }
}
