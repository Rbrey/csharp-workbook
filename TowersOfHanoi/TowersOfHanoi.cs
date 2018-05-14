using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack  = new Stack();

        }
    }

    // class Game
    // {
    //     public Tower[] Towers { get; set; }

    //     public Game()
    //     {
    //         this.Towers = new Dictionary

    //         Dictionary<string, string[]> categories = new Dictionary<string, string[]>();

    //         categories.Add("Stack A", new string[] {"","","",""});
    //         categories.Add("Stack B", new string[] {"","","",""});
    //         categories.Add("Stack C", new string[] {"","","",""});
    //     }
    // }

    class Stack
    {
        private Block[] blocks;
        public void PushBlock()
        {

        }
        public void PopBlock()
        {

        }
    }

    class Block
    {
        public Block (int weight)
        {
            this.Weight = weight;
        }
        public int Weight { get; private set; }
    }
}
