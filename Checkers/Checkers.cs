using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("//////////////////////////////////");
            Console.WriteLine("/////// WELCOME TO CHECKERS //////");
            Console.WriteLine("//////////////////////////////////");

            Game newGame = new Game();
            
            Console.WriteLine("Hello There!");
        }
    }

    #region Checker

    public class Checker
    {
        public string Symbol  { get; set; }
        public int[] Position  { get; set; }
        public string Color { get; set; }
        
        public Checker(string color, int[] position)
        {
            string circleId;
            if (color == "white")
            {
                circleId = "o";
            }
            else
            {
                circleId = "x";
            }
            this.Symbol = circleId;
            this.Position = position;
        }
    }

    #endregion

    #region Board
    public class Board
    {
        public string[][] Grid  { get; set; }
        public List<Checker> Checkers { get; set; }
        
        public Board()
        {            
            return;
        }
        // CREATE CHECKERS BOARD
        public void CreateBoard()
        {
            // Your code here
            this.Checkers = new List<Checker>();
            this.Grid = new string[][] {
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "}
            };
            return;
        }
        // DRAW CHECKER BOARD
        public void DrawBoard()
        {
            CreateBoard();
            PlaceCheckers();
            Console.WriteLine(" _|_0_|_1_|_2_|_3_|_4_|_5_|_6_|_7_");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(i + " |_" + String.Join(" |_", this.Grid[i]));
            }
            return;
        }
        
        public void GenerateCheckers()
        {
            // Your code here
            int[][] whitePositions = new int[][] {
                new int[] { 0, 1 }, new int[] { 0, 3 }, new int[] { 0, 5 }, new int[] { 0, 7 },
                new int[] { 1, 0 }, new int[] { 1, 2 }, new int[] { 1, 4 }, new int[] { 1, 6 },
                new int[] { 2, 1 }, new int[] { 2, 3 }, new int[] { 2, 5 }, new int[] { 2, 7 }
            };
            

            int[][] blackPositions = new int[][] {
                new int[] { 5, 0 }, new int[] { 5, 2 }, new int[] { 5, 4 }, new int[] { 5, 6 },
                new int[] { 6, 1 }, new int[] { 6, 3 }, new int[] { 6, 5 }, new int[] { 6, 7 },
                new int[] { 7, 0 }, new int[] { 7, 2 }, new int[] { 7, 4 }, new int[] { 7, 6 }
            };
            
            for (int i = 0; i < 12; i++)
            {
                Checker white = new Checker("white", whitePositions[i]);
                Checker black = new Checker("black", blackPositions[i]);
                Checkers.Add(white);
                Checkers.Add(black);
            }
            return;
        }
        
        public void PlaceCheckers()
        {
            foreach (var checker in Checkers)
            {
                this.Grid[checker.Position[0]][checker.Position[1]] = checker.Symbol;
            }
            return;
        }
        
        public Checker SelectChecker(int row, int column)
        {
            return Checkers.Find(x => x.Position.SequenceEqual(new List<int> { row, column }));
        }
        
        public void RemoveChecker(int row, int column)
        {
            // Your code here
            // this.Checkers.Remove(checker);
            return;
        }
        
        public bool CheckForWin()
        {
            return Checkers.All(x => x.Color == "white") || !Checkers.Exists(x => x.Color == "white");
        }
    }

    #endregion

    class Game
    {
        public Game()
        {
            // Your code here
            // CREATE ENTIRE BOARD
            Board board = new Board();
            
            board.GenerateCheckers();
            board.DrawBoard();
            // CHECKER MOVEMENT
            // PICK UP CHECKER
            Console.WriteLine("Enter Pickup Row:");
            int pickUpRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Pickup Column:");
            int pickUpColumn = Convert.ToInt32(Console.ReadLine());

            Checker checker = board.SelectChecker(pickUpRow, pickUpColumn);
            // PLACEMENT OF CHECKER
            Console.WriteLine("Enter Placement Row:");
            int placementRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Placement Column:");
            int placementColumn = Convert.ToInt32(Console.ReadLine());

            checker.Position = new int[] { placementRow, placementColumn };

            board.DrawBoard();
        }
    }
}