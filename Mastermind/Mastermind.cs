using System;
using System.Collections.Generic;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(new string[] {"a", "b", "c", "d"});
            for (int turns = 0; turns < 10; turns++)
            {
                Console.WriteLine("Choose four letters: ");
                string letters = Console.ReadLine();
                Ball[] balls = new Ball[4];
                for (int i = 0; i < 4; i++)
                {
                    balls[i] = new Ball (letters[i].ToString());
                }
                Row row = new Row(balls);
                game.AddRow(row);
                Console.WriteLine(game.Rows);
            }
            Console.WriteLine("Out of Turns");      
        }
    }

    class Game
    {
        private List<Row> rows = new List<Row>();
        private string[] answer = new string[4];
        private int turn = 0;
        private int red = 0;
        private int white = 0;
        public Game(string[] answer)
        {
            this.answer = answer;
        }
        private string Score(Row row)
        {
            string[] answerClone = (string[]) this.answer.Clone();
            for (int i = 0; i < 4; i++)
            {
                if (answerClone[i] == row.balls[i].Letter)
                {
                    this.red++;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                int foundIndex = Array.IndexOf(answerClone, row.balls[i].Letter);
                if (foundIndex > -1)
                {
                    this.white++;
                    answerClone[foundIndex] = null;
                }
            }
            this.turn++;
            return $" {red} - {white - red}";
        }
        public void AddRow(Row row)
        {
            this.rows.Add(row);
        }
        public string Rows
        {
            get
            {
                foreach (var row in this.rows)
                {
                    Console.Write(row.Balls);
                    Console.WriteLine(Score(row));
                }
                return $"You have {10 - turn} tries left";
            }
        }
    }
    class Ball
    {
        public string Letter { get; private set; }

        public Ball(string letter)
        {
            this.Letter = letter;
        }
    }
    class Row
    {
        public Ball[] balls = new Ball[4];

        public Row(Ball[] balls)
        {
            this.balls = balls;
        }
        public string Balls
        {
            get
            {
                foreach (var ball in this.balls)
                {
                    Console.Write(ball.Letter);
                }
                return "";
            }
        }
    }
}


// Add feature Win/Loss.
// if (red == 4)
// {
//      Console.WriteLine("You Win");
// }
// Pass in number of chances to start with.
// Generate random answer.