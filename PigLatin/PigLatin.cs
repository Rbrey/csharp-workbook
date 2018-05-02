using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            // your code goes here
            Console.WriteLine("What do you need translated?");
            string input = Console.ReadLine();

            Console.WriteLine(TranslateSentence(input));

            

            // Console.WriteLine(TranslateWord(input.ToLower()));
        }
        
        public static string TranslateWord(string word)
        {
            // your code goes here
            int firstVowel = word.IndexOfAny(new char[] {'a', 'e', 'i', 'o', 'u', 'y'});

            if (firstVowel == 0)
            {
                return word + "yay";
            }
            else
            {
                string partOne = word.Substring(0,firstVowel);
                string partTwo = word.Substring(firstVowel);

                return partTwo + partOne + "ay";
            }
        }
        
        public static string TranslateSentence(string sentence)
        {
            string[] words = sentence.Split(' ');
            string[] TranslatedWords = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                TranslatedWords[i] = TranslateWord(words[i]);
            }

            return string.Join(" ", TranslatedWords);
        }
    }
}