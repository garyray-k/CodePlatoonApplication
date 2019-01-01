using System;

/*
 * Write a method/function that takes two integers and returns the larger of two numbers when they are reversed.
 * Example:
 * max(15, 24)
 * # Returns 15 because 51 > 42
 */

namespace CodePlatoonApplication {
    internal class EasySolutionFour {

        internal static void Execute() {
            Console.WriteLine("Given two integers below 100, this application will reverse them and compare the results.");
            Console.WriteLine("i.e. 15 and 24 results in 15 because 51 > 42");
            Console.WriteLine("Enter the numbers to be considered:");
            string input = Console.ReadLine();
            try {
                var answer = SelectMaxFromReverseNumbers(input);
                Console.WriteLine(string.Format("The reverse Max is: {0}", answer));
            } catch (Exception ex) {
                System.Console.WriteLine(ex.Message);
            }
        }

        private static object SelectMaxFromReverseNumbers(string input) {
            string[] numbers = input.Split(' ');
            int firstReveresedNumber = 0;
            int secondReversedNumber = 0;
            if (numbers.Length != 2) throw new Exception("Must enter only 2 numbers!");
            try {
                Convert.ToInt32(numbers[0]);
                Convert.ToInt32(numbers[1]); 
                firstReveresedNumber = ReverseNumber(numbers[0]);
                secondReversedNumber = ReverseNumber(numbers[1]);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            int max = Math.Max(firstReveresedNumber, secondReversedNumber);
            if (max == firstReveresedNumber) {
                return numbers[0];
            }
            return numbers[1];

        }

        private static int ReverseNumber(string number) {
            char[] reversed = { number[1], number[0] };
            char second = number[1];
            return Convert.ToInt32(new string(reversed));
        }
    }
}
