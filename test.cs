using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randm = new Random():
            int rand_month = randm.Next(1,13);
            int rand_dice = randm.Next(1,7);
            int rand_card_value = randm.Next(52);

            Console.WriteLine(rand_month);
            Console.WriteLine(rand_dice);
            Console.WriteLine(rand_card_value);
        }
    }
}