using System;

/*
 * Write a method/function that calculates a dog's "true" age relative to the current year. 1 human year equals 7 dog years.
 * Example:
 * 
 * currentDogAge(2000) // would return 126
 * // A dog born in the year 2000 would be 126 years old in 2018
*/

namespace CodePlatoonApplication {
    internal class EasySolutionTwo {
        internal static void Execute() {
            Console.WriteLine("This applicaiton will calculate a dog's \"true\" age relative to current year (assuming 1 year = 7 dog years).");
            Console.WriteLine("Enter the year the dog was born:");
            string input = Console.ReadLine();
            try {
                var answer = CalculateDogAgeFromCurrentYear(input);
                if (answer != 0) {
                    System.Console.Write(string.Format("A dog born in {0} would be {1} years old in {2}.", input, answer, DateTime.Now.Year));
                }
            } catch (Exception ex) {
                System.Console.WriteLine(ex.Message);
            }
        }

        private static int CalculateDogAgeFromCurrentYear(string input) {
            int humanYears = 0;
            int yearBorn;
            int currentYear = DateTime.Now.Year;
            try {
                yearBorn = Convert.ToInt32(input);
                if (currentYear <= yearBorn) {
                    throw new Exception();
                }
                humanYears = currentYear - yearBorn;
            } catch (Exception ex) {
                Console.WriteLine("Invalid input. Please input a four digit year that is not this year or in the future.");
                Console.WriteLine(ex.Message);
            }
            return humanYears * 7;
        }
    }
}
