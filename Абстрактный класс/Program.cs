using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактный_класс
{
    abstract class Animal // абстрактный класс
    {
        public string name { get; set; }
        public Animal(string name) { this.name = name; }
        public abstract void Print(); // абстрактный метод
    }

    class Dog : Animal
    {
        private float speed;
        public Dog(string name, float speed) : base(name) /*Базовый конструктор*/
        {
            this.speed = speed;
        }
        public override void Print() // переопределение виртуального метода
        {
            Console.WriteLine("Dog Name = " + name);
            Console.WriteLine("Dog Speed = " + speed);
        }
    }

    class Cat : Animal
    {
        private float speed;
        public Cat(string name, float speed) : base(name)
        {
            this.speed = speed;
        }
        public override void Print()
        {
            Console.WriteLine("Cat Name = " + name);
            Console.WriteLine("Cat Speed = " + speed);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Console.Write("Enter amount of dogs: ");
            int amount = int.Parse(Console.ReadLine());
            for (int i = 0; i < amount; i++)
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
            }
            Console.ReadKey();
        }
    }
}
