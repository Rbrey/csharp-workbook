using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                bool Fizz = i % 3 == 0;
                bool Buzz = i % 5 == 0;
                if (Fizz && Buzz)
                {
                    Console.WriteLine("Fizzbuzz");
                }
                else if (Buzz)
                {
                    Console.WriteLine("Buzz");
                }
                else if (Fizz)
                {
                    Console.WriteLine("Fizz");
                }
                else
                    Console.WriteLine(i);
                
            }
        }
    }
}
