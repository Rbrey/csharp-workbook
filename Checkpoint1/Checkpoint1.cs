using System;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========");
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
            Console.WriteLine(counter);
            Console.WriteLine("==========");

            Console.WriteLine("==========");

            Console.WriteLine("==========");

            Console.WriteLine("==========");

            Console.WriteLine("==========");
        }
    }
}
