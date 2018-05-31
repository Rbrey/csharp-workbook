using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           Bird blueJay = new Bird();

            Console.WriteLine("Hello World!!!");
        }
    }

    class Animal
    {
        public void eat()
        {
            Console.WriteLine("Nom, nom, nom.");
        }

        public void breath()
        {
            Console.WriteLine("Breath in, breath out.");
        }
    }

    class Vertebrate : Animal
    {
        public bool backBone = true;
    }

    class Invertebrate : Animal
    {
        public bool backBone = false;
    }

    class Bird : Vertebrate
    {
        public void fly()
        {
            Console.WriteLine("Flappy flap.");
        }
    }
}
