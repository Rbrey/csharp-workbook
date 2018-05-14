using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========");
            Problem1();
            Console.WriteLine("==========");
            Problem2();
            Console.WriteLine("==========");
            Problem3();
            Console.WriteLine("==========");
            Problem4();
            Console.WriteLine("==========");
            Problem5();
            Console.WriteLine("==========");
        }
        //----------------------------------------------------------------------
        public static void Problem1()
        {
            int counter = 0;
            int num = 1;
            while(num != 101)
            {
                if (num % 3 == 0)
                {
                    counter++;
                    num++;
                }
                else
                {
                    num++;
                }
            }
            Console.WriteLine("Numbers divisible by 3 with no remainder" );
            Console.WriteLine(counter);
        }
        //----------------------------------------------------------------------
        public static void Problem2()
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number");
                string input = Console.ReadLine();

                if (input == "ok")
                {
                    break;
                }
                int number = Convert.ToInt32(input);
                sum += number;
            }
            Console.WriteLine("The sum of the numbers you entered is: {0}", sum);
        }
        //----------------------------------------------------------------------
        public static void Problem3()
        {
            Console.WriteLine("Type in the number to find it's factorial");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} = {1}", number, Factorial(number));
        }
        private static int Factorial(int number)
        {
            if (number == 0 || number == 1)
                return 1;

            return number * Factorial(number - 1);
        }
        //----------------------------------------------------------------------
        public static void Problem4()
        {
            Console.WriteLine("Guess a number from 1 to 10. You have 4 chances");
            int randomNumber = GenerateRandomNumber();
            AttemptToGuess(randomNumber);
        }
        private static int GenerateRandomNumber()
        {
            var random = new Random();
            return random.Next(1, 10);
        }
        private static void AttemptToGuess(int randomNumber)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Try #{0}: ", i);
                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer == randomNumber)
                {
                    Console.WriteLine("You won!");
                    break;
                }

                if (OutOfTries(i))
                {
                    Console.WriteLine("You lost.");
                    break;
                }
                
                Console.WriteLine("Wrong guess, try again!");
            }
        }
        private static bool OutOfTries(int i)
        {
            return i == 3;
        }
        //----------------------------------------------------------------------
        public static void Problem5()
        {
            Console.WriteLine("Enter a series of numbers seperated by commas (Example: 1, 2, 3)");
            string input = Console.ReadLine();
            var numbers = NumberList(input);
            var max = numbers?.Max();

            Console.WriteLine("The maximum number is: " + max);
        }
        private static IEnumerable<int> NumberList(string input)
        {
            return input?.Split(',').Select(number => Convert.ToInt32(number.Trim())).ToList();
        }
    }   
}
