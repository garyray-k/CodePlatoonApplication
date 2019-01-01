using System;
using System.Collections.Generic;

namespace CodePlatoonApplication {
    internal class EasySolutionThree {
        internal static void Execute() {
            Console.WriteLine("This applicaiton will identify the number of colors in a given string of words.");
            Console.WriteLine("Enter the string to be considered:");
            string input = Console.ReadLine();
            try {
                var answer = IdentifyColorsWithinString(input);
                Console.WriteLine(string.Format("There are {0} color words.", answer));
            } catch (Exception ex) {
                System.Console.WriteLine(ex.Message);
            }
        }

        private static int IdentifyColorsWithinString(string input) {
            string[] words = input.Split(' '); 
            int colorWordCount = 0;
            foreach (string word in words) {
                if (IsColorWord(word)) colorWordCount++;
            }
            return colorWordCount;
        }

        private static bool IsColorWord(string word) {
            List<string> eligibleColors = new List<string> { "blue", "green", "brown", "gray", "red", "black", "purple" } ;
            return eligibleColors.Contains(word);
        }
    }
}