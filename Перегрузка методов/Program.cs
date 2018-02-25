using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузка_методов
{
    struct Book
    {
        private string title;
        private string name;
        private string author;
        public Book(string title, string name, string author)
        {
            this.author = author;
            this.name = name;
            this.title = title;
        }
        public void Print()
        {
            Console.WriteLine(title);
            Console.WriteLine(author);
            Console.WriteLine(name);
        }
    }

    enum Breed { Dog, Cat, Bird, Bear, Tiger };

    class Animal
    {
        private Breed breed;
        public Animal(Breed breed)
        {
            this.breed = breed;
        }
        public void Print()
        {
            Console.WriteLine(breed);
        }
    }

    class Some
    {
        public void Multiply(int a, int b) // перегрузка метода
        {
            Console.WriteLine("Result is {0}", a * b);
        }
        public void Multiply(int a, int b, int c)
        {
            Console.WriteLine("Result is {0}", a * b * c);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("HORROR", "FRIDAY", "KING");
            b1.Print();

            Animal dog = new Animal(Breed.Tiger);
            dog.Print();

            //Some test = new Some();
            //test.Multiply(10, 23);
            //test.Multiply(10, 23, 3);

            Console.ReadKey();
        }
    }
}
