using System;

namespace TicTacToe
{
    class Program
    {
        public static string playerTurn = "O";
        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

        public static void Main()
        {
            do
            {
                DrawBoard();
                GetInput();
            } while (!CheckForWin() && !CheckForTie());

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static void GetInput()
        {
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());
            PlaceMark(row, column);
        }

        public static void PlaceMark(int row, int column)
        {
            playerTurn = (playerTurn == "X") ? "O" : "X";
            board[row][column] = playerTurn;
        }

        public static bool CheckForWin()
        {
            // your code goes here
            HorizontalWin();
            VerticalWin();
            DiagonalWin();

            return false;
        }

        public static bool CheckForTie()
        {
            // your code goes here
            if (!HorizontalWin() || !VerticalWin() || !DiagonalWin() ||
                board[0][0] != "" || board[0][1] != "" || board[0][2] != "" ||
                board[1][0] != "" || board[1][1] != "" || board[1][2] != "" ||
                board[2][0] != "" || board[2][1] != "" || board[2][2] != "")
            {
                Console.WriteLine("=======");
                Console.WriteLine("Tie Game!");
                Console.WriteLine("=======");
            }
            return false;
        }
        
        public static bool HorizontalWin()
        {
            // your code goes here
            if (board[0][0] == playerTurn && board[0][1] == playerTurn && board[0][2] == playerTurn ||
                board[1][0] == playerTurn && board[1][1] == playerTurn && board[1][2] == playerTurn ||
                board[2][0] == playerTurn && board[2][1] == playerTurn && board[2][2] == playerTurn)
            {
                Console.WriteLine("=======");
                Console.WriteLine(playerTurn + " Wins Horizontal!");
                Console.WriteLine("=======");
                
            }
            return false;
            }

        public static bool VerticalWin()
        {
            // your code goes here
            if (board[0][0] == playerTurn && board[1][0] == playerTurn && board[2][0] == playerTurn ||
                board[0][1] == playerTurn && board[1][1] == playerTurn && board[2][1] == playerTurn ||
                board[0][2] == playerTurn && board[1][2] == playerTurn && board[2][2] == playerTurn)
        {
            Console.WriteLine("=======");
            Console.WriteLine(playerTurn + " Wins Vertical!");
            Console.WriteLine("=======");
            
        }
        return false;
        }

        public static bool DiagonalWin()
        {
            // your code goes here
            if (board[0][0] == playerTurn && board[1][1] == playerTurn && board[2][2] == playerTurn ||
                board[0][2] == playerTurn && board[1][1] == playerTurn && board[2][0] == playerTurn)
        {
            Console.WriteLine("=======");
            Console.WriteLine(playerTurn + " Wins Diangonal!");
            Console.WriteLine("=======");
            
        }
        return false;
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }
    }
}
