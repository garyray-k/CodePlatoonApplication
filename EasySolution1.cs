using System;

/* 
 * Write a method/function that takes a string and counts the number of words that begin and end with the same letter.
 * Example:
 * same_first_and_last('Trout like to eat toast when they see a kayak')
 * # Returns number 4 because trout, toast, a, and kayak start and end with the same letter.
*/

namespace CodePlatoonApplication {
    public static class EasySolutionOne {
        public static void Execute() {
            System.Console.WriteLine("This applicaiton will check a series of words to determine if the first and last letter of the word are the same.");
            System.Console.WriteLine("Enter your words to be parsed:");
            string input = Console.ReadLine();
            try {
                System.Console.Write("Words with same beginning and end: ");
                Console.WriteLine(CountWordsWithSameBeginningAndEnd(input.Split(' ')));
            } catch (IndexOutOfRangeException ex) {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine("In other words: There was nothing to parse!");
            }
        }

        static int CountWordsWithSameBeginningAndEnd(string[] sentence) {
            int totalCount = 0;
            foreach (var word in sentence) {
                if (SameLetterBeginningAndEnd(word)) {
                    // debug line: System.Console.WriteLine(word + " is counted.");
                    totalCount++;
                }
            }
            return totalCount;
        }

        static bool SameLetterBeginningAndEnd(string word) {
            char firstLetter = Char.ToLower(word[0]);
            char lastLetter = Char.ToLower(word[word.Length - 1]);
            return firstLetter == lastLetter;
        }
    }
}
