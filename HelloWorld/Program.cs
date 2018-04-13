using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Robert!");

            Console.WriteLine("Welcome to Fantasy Character Descriptor");

            string name = "";
            int age = 0;
            string race = "";
            string eyes = "";
            string hair = "";
            string faction = "";
            string alignment = "";
            int family = 0;

            Console.WriteLine("Please enter character name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter character age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter character race: ");
            race = Console.ReadLine();
            Console.WriteLine("Please enter character eye color: ");
            eyes = Console.ReadLine();
            Console.WriteLine("Please enter character hair color: ");
            hair = Console.ReadLine();
            Console.WriteLine("Please enter character faction: ");
            faction = Console.ReadLine();
            Console.WriteLine("Please enter character alignment: ");
            alignment = Console.ReadLine();
            Console.WriteLine("Please enter character family members alive: ");
            family = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Hello! My name is {0} and I am {1} years old. I was born a/an {2}. My eyes are {3}.", name, age, race, eyes);
            Console.WriteLine("My hair is/are {0}. I am apart of {1}. I am {2}. I have {3} family member/s alive", hair, faction, alignment, family);
        }
    }
}