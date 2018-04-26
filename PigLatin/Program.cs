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
            // leave this command at the end so your program does not close automatically
            
            Console.ReadLine();
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
        
        public static string TranslateSentence(string sentence)
        {
            string[] words = sentence.Split(' ');

            for (int i =0; i < words.Length; i++)
            {
                words[i] = TranslateWord(words[i]);
            }
            return string sentence String = string.Join(' ', sentence);
        }
    }
}