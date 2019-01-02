using System;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;

/*
 * For this problem, write a function/method that takes in a string and returns it in Pig Latin. 
 * If you are unfamiliar with Pig Latin check out: https://en.wikipedia.org/wiki/Pig_Latin. For our purposes today, let's follow one rule:
 * If a word starts with a consonant move all the letters before the first vowel to the end and add 'ay'. 
 * If a word starts with a vowel (count 'y' as a vowel) just add 'way'.
 * Examples:
 * pigLatin('bob') // returns 'obbay'
 * pigLatin("bob") // returns "obbay"
 * pigLatin("pig") // returns "igpay"
 * pigLatin("latin") // returns "atinlay"
 * pigLatin("banana") // returns "ananabay"
 * pigLatin("school") // returns "oolschay"
 * pigLatin("one") // returns "oneway"
 * pigLatin("or") // returns "orway"
 * pigLatin("This is a test") // returns "isThay isway away esttay"
*/

namespace CodePlatoonApplication {
    internal class HardSolutionOne {
        private static readonly char[] Vowels = { 'a', 'e', 'i', 'o', 'u' };

        internal static void Execute() {
            Console.WriteLine("Let's turn some things into PigLatin.");
            Console.WriteLine("Enter a phrase:");
            string input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input)) throw new Exception("Must provide words to be converted.");
            string answer = ConvertToPigLatin(input);
            Console.WriteLine(answer);
        }

        private static string ConvertToPigLatin(string input) {
            string[] wordsToBeConverted = input.Split(' ');
            string result = "";
            foreach (string word in wordsToBeConverted) {
                if (!Regex.IsMatch(word, @"^[a-zA-Z]+$")) throw new Exception("Words only. No numbers or unique characters");
                if (FirstLetterIsVowel(word)) { 
                    result += ConvertVowelFirstWord(word); 
                } else { 
                    result += (ConvertConsonantFirstWord(word); 
                }
            }
            return result;
        }

        private static bool FirstLetterIsVowel(string word) {
            char[] charOfWord = word.ToCharArray();
            return IsLetterAVowel(charOfWord[0]);
        }

        private static bool IsLetterAVowel(char v) {
            return Vowels.Contains(Char.ToLower(v));
        }

        private static string ConvertVowelFirstWord(string word) {
            return word + "way";
        }

        private static string ConvertConsonantFirstWord(string word) {
            char[] charArrayOfWord = word.ToCharArray();
            int indexOfFirstVowel = FindIndexOfFirstVowel(charArrayOfWord);
            return word.Substring(indexOfFirstVowel) + word.Substring(0, indexOfFirstVowel) + "ay";
        }

        private static int FindIndexOfFirstVowel(char[] charArrayOfWord) {
            foreach (char letter in charArrayOfWord) {
                if (IsLetterAVowel(letter) || letter == Char.ToLower('y')) {
                    return Array.IndexOf(charArrayOfWord, letter);
                }
                continue;
            }
            throw new Exception("Vowel not found in word. Maybe it's not a real word? Use real words.");
        }
    }

    [TestFixture]
    public class HardSolutionOne_ConvertsToPigLatin {
        private readonly HardSolutionOne _hardSolutionOne;

        public HardSolutionOne_ConvertsToPigLatin() {
            _hardSolutionOne = new HardSolutionOne();
        }

    }
}


