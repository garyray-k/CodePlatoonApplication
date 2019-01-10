using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

/*
 * Write a method that takes in a string and outputs the the number of occurrences that a character shows up in a Hash. 
 * This output hash should be ordered by the number of occurences in descending order. 
 * You can ignore spacing, capitalization, and punctuation.
 * Examples:
 * number_of_occurrences('aaabbc')
 * # returns
 * number_of_occurrences('an apple a day will keep the doctor away')
 * # returns
*/

namespace CodePlatoonApplication {
    internal class HardSolutionTwo {
        internal static void Execute() {
            Console.WriteLine("Enter a string to be analyzed:");
            string input = Console.ReadLine();
            Dictionary<char, int> characterDict = new Dictionary<char, int> { };
            foreach (char letter in input) {
                char lowerLetter = char.ToLower(letter);
                bool IsNotALetter = !Regex.IsMatch(lowerLetter.ToString(), "[a-zA-Z]+");
                if (IsNotALetter) continue;

                if (characterDict.ContainsKey(lowerLetter)) {
                    characterDict[letter]++;
                    continue;
                }

                characterDict.Add(lowerLetter, 1);
            }
            var answer = characterDict.OrderByDescending(x => x.Value);
            foreach (var key in answer ) {
                Console.WriteLine($"{key.Key} : {key.Value}");
            }
        }
    }
}
