using System;
using System.Collections.Generic; // Подключение контейнеров STL

namespace Консольное_приложение_С_sharp__test_
{
    #region ООП
    /*
     class Student
    {
        public static int count = 0;
        int age = 18; // автоматически приватный модификатор доступа
        private int course = 1;
        private bool fee = false;
        private int secretNum;

        public int Passworld { get; private set; } // автоматический аксессор

        public int SecretNum // Аксессор
        {
            get
            {
                return secretNum;
            }
            set
            {
                if (value > 10)
                    secretNum = 10;
                else if (value < 0)
                    secretNum = 0;
                else
                    secretNum = value;
            }
        }

        public Student() { count++; Print(); Passworld = 0; }

        public Student(int age, int course, bool _fee, int pass)
        {
            this.age = age; // работа через указатель this
            this.course = course;
            fee = _fee;
            Passworld = pass;
            count++;
            Print();
        }

        private void Print()
        {
            Console.WriteLine("Age of student {0}", age); //интерполяция строк
            Console.WriteLine("Course {0}", course);
            Console.WriteLine("Scholar " + Convert.ToString(fee));
            Console.WriteLine("Passworld {0}", Passworld);
            Console.WriteLine();
        }
    }
    */
    #endregion

    #region Наследование

    class Animal
    {
        public string name { get; set; }
        public Animal(string name) { this.name = name; }
        public virtual void Print() // виртуальный метод (можно переопределять в классах наследниках)
        {
            Console.WriteLine(name);
        }
    }

    class Dog : Animal
    {
        private float speed;
        public Dog(string name, float speed) : base(name) /*Базовый конструктор*/
        {
            this.speed = speed;
            //Console.WriteLine("Speed = " + speed); //конкатенация строк
        }
        public override void Print() // переопределение виртуального метода
        {
            base.Print(); // берём из главного метода весь код
            Console.WriteLine("Dog Speed = " + speed);
        }
    }

    class Cat : Animal
    {
        private float speed;
        public Cat(string name, float speed) : base(name) /*Базовый конструктор*/
        {
            this.speed = speed;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Cat Speed = " + speed);
        }
    }


    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            #region ООП
            /*
            Student Pety = new Student();
            //Student.count++; // Прямое обращение к static 
            Student Masha = new Student(19, 2, true, 1234);
            Student Maria = new Student(20, 3, false, 9021);
            Maria.SecretNum = 15; // обращение к аксессору
            Console.WriteLine("Secret number = {0}", Maria.SecretNum);
            Console.WriteLine("Общее число студентов в базе данных: {0}", Student.count);
            */
            #endregion
            #region Наследование
            /*
            Dog tom = new Dog("Tom", 10.5f);
            tom.Print();
            Console.WriteLine();
            Dog jerry = new Dog("Jerry", 20.25f);
            jerry.Print();
            */
            #endregion
            #region List

            List<Animal> animals = new List<Animal>(); // Колекция
            Console.Write("Enter amount of dogs: ");
            int amount = int.Parse(Console.ReadLine());
            for(int i = 0; i < amount; i++)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter speed: ");
                float sp = float.Parse(Console.ReadLine());
                animals.Add(new Dog(name, sp));
            }
            Console.Write("Enter amount of cats: ");
            amount = int.Parse(Console.ReadLine());
            for (int i = 0; i < amount; i++)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter speed: ");
                float sp = float.Parse(Console.ReadLine());
                animals.Add(new Cat(name, sp));
            }
            foreach (Animal anim in animals)
            {
                anim.Print();
                /*
                if (anim is Cat) // is проверяет на принадлежность anim к классу Cat
                    Console.WriteLine(anim.name);
                else if (anim is Dog)
                    Console.WriteLine(anim.name);
                    */
            }

            #endregion
            Console.ReadKey();
        }
    }
}
