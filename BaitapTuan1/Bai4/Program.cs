using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat khoaiLangTheCat = new Cat("Khoai Lang");
            khoaiLangTheCat.Sound();
            Dog jonTheDog = new Dog("Jon");
            jonTheDog.Sound();
            Console.ReadLine();
        }
    }

    class Cat : Animal
    {
        string name;

        public Cat(string name)
        {
            this.name = name;
        }
        public override void Sound()
        {
            Console.WriteLine($"The cat {this.name} says \"Meow meow!\".");
        }
    }

    class Dog : Animal
    {
        string name;

        public Dog(string name)
        {
            this.name = name;
        }
        public override void Sound()
        {
            Console.WriteLine($"The dog {this.name} says \"Go go!\".");
        }

    }
}
