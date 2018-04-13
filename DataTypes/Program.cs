using System;
using System.Threading;

namespace DataTypes
{
    class Program
    {
        public static void Main(string[] args)
        {
            string ch1 = "";
            string ch2 = "";
            string ch3 = "";


            Console.WriteLine("|================================|");
            Console.WriteLine("|Welcome to the Cavern of Secrets|");
            Console.WriteLine("|================================|");

            Thread.Sleep(5000);

            Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor.");
            Console.WriteLine("Do you take it? [y/n]: ");
            ch1 = Console.ReadLine();

            // Stick Taken
            if (ch1 == "y")
            {
                int stick = 1;
                Console.WriteLine("You have taken the stick. You now have {0} stick.", stick);
                Thread.Sleep(2000);
            }
            // Stick Not Taken
            else
            {
                Console.WriteLine("You did not take the stick.");
                int stick = 0;
            }

            Console.WriteLine("As you proceed further into the cave, you see a small glowing object.");
            Console.WriteLine("Do you approach the object? [y/n]: ");
            ch2 = Console.ReadLine();

                // Approach Spider
                if (ch2 == "y")
                {
                    Console.WriteLine("You approach the object...");
                    Thread.Sleep(2000);
                    Console.WriteLine("As you draw closer, you begin to make out the object as an eye!");
                    Thread.Sleep(2000);
                    Console.WriteLine("The eye belongs to a giant spider!");
                    Console.WriteLine("Do you try to fight it? [y/n]: ");
                    ch3 = Console.ReadLine();

                // Fight Spider
                if (ch3 == "y")
                {
                    // With Stick
                    int stick = 1;
                    if (stick == 1)
                    {
                        Console.WriteLine("You only have a stick to fight with!");
                        Console.WriteLine("You quickly jab the spider in one eye and gain the advantage!");
                        Thread.Sleep(2000);
                        Console.WriteLine("|==================================================|");
                        Console.WriteLine("|                   Fighting                       |");
                        Console.WriteLine("|        HIT ABOVE A FIVE TO KILL THE SPIDER       |");
                        Console.WriteLine("| IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE |");
                        Console.WriteLine("|==================================================|");
                        Thread.Sleep(2000);
                        Random randm = new Random();
                        int pDmg = randm.Next(3,10);
                        int gsDmg = randm.Next(1,5);
                        Console.WriteLine("You hit a, {0}", pDmg);
                        Console.WriteLine("Giant Spider hit a, {0}", gsDmg);
                        Thread.Sleep(2000);

                        if (gsDmg > pDmg)
                        {
                            Console.WriteLine("The giant spider had dealt more damage than you!");
                            bool live = false;
                            if (live == true)
                            {
                                Console.WriteLine("You escape alive!");
                            }
                            else
                            {
                                Console.WriteLine("You escape dead, you know soul leaving the body and all that rubbish");
                            }
                        }
                        else if (pDmg < 5)
                        {
                            Console.WriteLine("You didn't do enough damage to kill the spider, but you manage to escape.");
                            bool live = false;
                            if (live == true)
                            {
                                Console.WriteLine("You escape alive!");
                            }
                            else
                            {
                                Console.WriteLine("You escape dead, you know soul leaving the body and all that rubbish");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You killed the giant spider!");
                            bool live = true;
                            if (live == true)
                            {
                                Console.WriteLine("You escape alive!");
                            }
                            else
                            {
                                Console.WriteLine("You escape dead, you know soul leaving the body and all that rubbish");
                            }
                        }
                    }
                }
                // Don't Fight Spider
                else
                {
                    Console.WriteLine("You choose not to fight the giant spider.");
                    Thread.Sleep(2000);
                    Console.WriteLine("As you turn away, it ambushes you and impales you with it's fangs!");
                    bool live = false;

                    if (live == true)
                    {
                        Console.WriteLine("You escape alive!");
                    }
                    else
                    {
                        Console.WriteLine("You escape dead, you know soul leaving the body and all that rubbish");
                    }
                }
            }
            else
            {
                Console.WriteLine("You turn away from the glowing object and leave the cave.");
                Thread.Sleep(10000);
                Console.WriteLine("As you grow old you think back on that day, what could have been?");
            }
// =================================================================        
        }
    }
}
