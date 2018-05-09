using System;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack tower1 = new Stack(8);
            Stack tower2 = new Stack(8);
            Stack tower3 = new Stack(8);
            DrawBoard(tower1, tower2, tower3);

            Console.ReadLine();
        }
        public static void DrawBoard(Stack tower1, Stack tower2, Stack tower3)
        {
            Console.Clear();
            tower1.drawTower(20);
            tower2.drawTower(40);
            tower3.drawTower(60);
        }
    }

    class Stack
    {
        private int stackHeight;
        private int y = 3;
        int[] rings = new int[0];
        public Stack(int height)
        {
            stackHeight = height;
        }

        public void AddBlock(int size)
        {
            Array.Resize(ref rings, rings.Length + 1);
            rings[rings.Length - 1] = size;
        }

        public void drawTower(int x)
        {
            for (int i = 1; i <= stackHeight; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine("|");
                y++;
            }
            if (x < 7)
            {
                x = 7;
            }
            Console.SetCursorPosition(x - 7, y);
            Console.WriteLine("===============");
        }
    }

    class Ring
    {

    }
}
