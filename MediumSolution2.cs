using System;

/*
 * Write a function/method that takes a number to insert and an array of integers, 
 * return the lowest index at which the number to insert can be put into the array of numbers. 
 * Assume that the array of numbers is always sorted.
 * Example:
 * lowest_index_insert(3, [1,2,5])
 * # returns 2 because index 2 of the array is the where the number to insert (3) would be inserted
*/

namespace CodePlatoonApplication {
    internal class MediumSolutionTwo {
        internal static void Execute() {
            Console.WriteLine("Enter the number to be inject");
            int inputNumber = 0; 
            try {
                inputNumber = Convert.ToInt32(Console.ReadLine());
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
            Console.WriteLine("Enter the array you'd like to inject into:");
            string inputString = Console.ReadLine();
            string[] inputStringArray = inputString.Split(',');
            int answer = 0;
            foreach (string word in inputStringArray) {
                int number = Convert.ToInt32(word);
                if (number > inputNumber) {
                    answer = Array.FindIndex(inputStringArray, x => x.Contains(word));
                    break;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
