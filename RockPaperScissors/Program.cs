using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            bool keepPlaying = true;
            int cScore = 0;
            int pScore = 0;
            while (keepPlaying && cScore < 5 && pScore < 5)
            {            
                Console.WriteLine("");
                // Title
                Console.WriteLine("===============================");
                Console.WriteLine("******Rock Paper Scissors******");
                Console.WriteLine("===============================");
                // Player
                Console.WriteLine("Enter Player Hand:");
                Console.WriteLine("==================");
                string player = Console.ReadLine().ToLower();
                // Computer
                Random comphand = new Random();
                int computer = comphand.Next(3);
                // Scoring
                if (computer == 1)
                {
                    cScore++;
                }
                else if (computer == 2)
                {
                    pScore++;
                }
                // Win
                if (cScore == 5)
                {
                    Console.WriteLine("COMPUTER WINS!");
                }
                else if (pScore == 5)
                {
                    Console.WriteLine("PLAYER WINS!");
                }

                Console.WriteLine(CompareHands(player, computer));
                Console.WriteLine("==========");
                Console.WriteLine("Scoreboard");
                Console.WriteLine("==========");
                Console.WriteLine("Player: " + pScore);
                Console.WriteLine("Computer: " + cScore);
            }
            // Console.WriteLine("New Game? y/n");
            // ConsoleKeyInfo cki = Console.ReadKey();
            // keepPlaying = cki.KeyChar == 'y';
            // Console.Clear();
            
            // leave this command at the end so your program does not close automatically
            // Console.ReadLine();
        }
        public static string CompareHands(string player, int computer)
        {
            // Your code here
            if (computer == 0)
            {
                if (player == "rock")
                {
                    Console.WriteLine("Computer chooses Rock, it's a tie!");
                }
                else if (player == "paper")
                {
                    Console.WriteLine("Computer chooses Paper, it's a tie!");
                }
                else if (player == "scissors")
                {
                    Console.WriteLine("Computer chooses Scissors, it's a tie!");
                }
                else
                {
                    Console.WriteLine("=========================================");
                    Console.WriteLine("YOU MUST CHOOSE ROCK, PAPER, OR SCISSORS!");
                    Console.WriteLine("=========================================");
                }
            }
            
            if (computer == 1)
            {
                if (player == "rock")
                {
                    Console.WriteLine("Computer chooses Paper, you lose!");
                }
                else if (player == "paper")
                {
                    Console.WriteLine("Computer chooses Scissors, you lose!");
                }
                else if (player == "scissors")
                {
                    Console.WriteLine("Computer chooses Rock, you lose!");
                }
                else
                {
                    Console.WriteLine("=========================================");
                    Console.WriteLine("YOU MUST CHOOSE ROCK, PAPER, OR SCISSORS!");
                    Console.WriteLine("=========================================");
                }
            }

            if (computer == 2)
            {
                if (player == "rock")
                {
                    Console.WriteLine("Computer chooses Scissors, you win!");
                }
                else if (player == "paper")
                {
                    Console.WriteLine("Computer chooses Rock, you win!");
                }
                else if (player == "scissors")
                {
                    Console.WriteLine("Computer chooses Paper, you win!");
                }
                else
                {
                    Console.WriteLine("=========================================");
                    Console.WriteLine("YOU MUST CHOOSE ROCK, PAPER, OR SCISSORS!");
                    Console.WriteLine("=========================================");
                }
            }

            return player + ' ' + computer;
        }
    }
}


// ***Notes***
// string[] plays = new []  { "rock", "paper", "scissors" };

// random rnd = new random();
// int randomInteger = randomInteger.next(0, 3);
// string hand2 = plays[randomInteger];