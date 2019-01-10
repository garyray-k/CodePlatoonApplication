using System;

/*
 * Write a function/method that takes an array of integers and a desired sum. 
 * The output should be pairs of numbers from the array of integers that equal the desired sum. 
 * If there are no pairs that work, return unable to find pairs
 * Examples:
 * sumPairs([1,2,3,4,5], 9)
 * // returns [4,5] because only the numbers 4 and 5 when added together equal the target number of 9
 * sumPairs([3,1,5,8,2], 27)
 * // returns 'unable to find pairs' because there are no pairs of numbers that sum to 27
*/

namespace CodePlatoonApplication {
    internal class MediumSolutionOne {
        internal static void Execute() {
            Console.WriteLine("Enter the desired sum:");
            int desiredSum = 0;
            try {
                desiredSum = Convert.ToInt32(Console.ReadLine());
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
            Console.WriteLine("Enter a comma seperated array of integers:");
            string input = Console.ReadLine();

            int[] intInput = ConvertStringToIntegerArray(input);
            int[] answer = DetermineIfSumAvailableFromArray(desiredSum, intInput);
            Console.WriteLine(string.Format("{0},{1}", answer[0], answer[1]));
        }

        private static int[] ConvertStringToIntegerArray(string input) {
            string[] stringArray = input.Split(',');
            int[] intArray = new int[stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++) {
                intArray[i] = Convert.ToInt32(stringArray[i]);
            }
            return intArray;
        }

        private static int[] DetermineIfSumAvailableFromArray(int desiredSum, int[] intInput) {
            int[] result = new int[2];
            for (int i = 0; i < intInput.Length - 1; i++) {
                int j = i + 1;
                while (j < intInput.Length) {
                    if (intInput[i] + intInput[j] == desiredSum) {
                        result[0] = intInput[i];
                        result[1] = intInput[j];
                        return result;
                    };
                    j++;
                }
            }
            Console.WriteLine("unable to find pairs");
            Environment.Exit(0);
            return null;
        }
    }

}
