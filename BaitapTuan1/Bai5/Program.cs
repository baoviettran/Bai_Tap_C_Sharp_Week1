using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat khoaiLangTheCat = new Cat();
            khoaiLangTheCat.Sound();
            Dog jonTheDog = new Dog();
            jonTheDog.Sound();
            Console.ReadLine();
        }
    }
    class Cat : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Meow meow!");
        }
    }

    class Dog : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Go go!");
        }

    }
}
