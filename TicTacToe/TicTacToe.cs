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

        public static int turn = 0;
        public static void Main()
        {
            do
            {
                turn++;
                playerTurn = (playerTurn == "X") ? "O" : "X";
                DrawBoard();
                GetInput();

            } while (!CheckForWin() && !CheckForTie());
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
            board[row][column] = playerTurn;
        }

        public static bool CheckForWin()
        {
            // your code goes here
           if (board[0][0] == playerTurn && board[0][1] == playerTurn && board[0][2] == playerTurn ||
                board[1][0] == playerTurn && board[1][1] == playerTurn && board[1][2] == playerTurn ||
                board[2][0] == playerTurn && board[2][1] == playerTurn && board[2][2] == playerTurn ||
                board[0][0] == playerTurn && board[1][0] == playerTurn && board[2][0] == playerTurn ||
                board[0][2] == playerTurn && board[1][2] == playerTurn && board[2][2] == playerTurn ||
                board[0][0] == playerTurn && board[1][1] == playerTurn && board[2][2] == playerTurn ||
                board[0][2] == playerTurn && board[1][1] == playerTurn && board[2][0] == playerTurn)
            {
                Console.WriteLine("=======");
                Console.WriteLine(playerTurn + " Wins!!!");
                Console.WriteLine("=======");
            }
            return false;
            }

        public static bool CheckForTie()
        {
            // your code goes here
            if (turn == 9)
            {
                Console.WriteLine("=======");
                Console.WriteLine("Players Tie!!!");
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
