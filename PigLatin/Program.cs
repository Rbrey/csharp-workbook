using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            // your code goes here
            string word = "";
            Console.WriteLine("What do you need translated?");
            word = Console.ReadLine();
            Console.WriteLine(TranslateWord(word));
            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        public static string TranslateWord(string word)
        {
            // your code goes here
            string[] words = word.Split(' ');
            word = string.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= 1) continue;
                string output = new string(words[i].ToCharArray());
                output = output.Substring(1, output.Length -1) + output.Substring(0, 1) + "ay";
                word += output;
            }

            return word;
        }
    }
}
