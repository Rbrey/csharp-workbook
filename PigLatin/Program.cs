using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            // your code goes here
            string input;
            Console.WriteLine("What do you need translated?");
            input = Console.ReadLine();
            Console.WriteLine(TranslateWord(input.ToLower()));
            Console.WriteLine(TranslateSentence(input));
        }
        
        public static string TranslateWord(string input)
        {
            // your code goes here
            int firstVowel = input.IndexOfAny(new char[] {'a', 'e', 'i', 'o', 'u'});

            string partOne = input.Substring(0,firstVowel);
            string partTwo = input.Substring(firstVowel);
            input = input.ToLower();

            if (firstVowel == 0)
            {
                return input + "yay";
            }
            else
            {
                return partTwo + partOne + "ay";
            }
        }
        
        public static string TranslateSentence(string input)
        {
            foreach (string word in input.Split())
            {
                TranslateWord(input);
            }
            return TranslateWord(input);
        }
    }
}