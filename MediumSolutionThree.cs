using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Write a function/method that takes in a string and spells that word out using the NATO Phonetic Alphabet.
 * Example:
 * nato_alphabet('code platoon')
 * # returns 'charlie oscar delta echo papa lima alpha tango oscar oscar november'
 */

namespace CodePlatoonApplication {
    internal class MediumSolutionThree {
        internal static void Execute() {
            Dictionary<char, string> natoAlphabet = new Dictionary<char, string>() {
                { 'A',"Alpha" }, 
                { 'B',"Bravo" },
                { 'C',"Charlie" }, 
                { 'D',"Delta" }, 
                { 'E',"Echo" }, 
                { 'F',"Foxtrot" },
                { 'G',"Golf" },
                { 'I',"India" },
                { 'J',"Juliet" },
                { 'K',"Kilo" },
                { 'L',"Lima" },
                { 'M',"Mike" },
                { 'N',"November" },
                { 'O',"Oscar" },
                { 'P',"Papa" },
                { 'Q',"Quebec" },
                { 'R',"Romeo" },
                { 'S',"Sierra" },
                { 'T',"Tango" },
                { 'U',"Uniform" },
                { 'V',"Victor" },
                { 'W',"Whiskey" },
                { 'X',"Xray" },
                { 'Y',"Yankee" },
                { 'Z',"Zulu" }
            };
            Console.WriteLine("Enter a string to be NATOized:");
            string input = Console.ReadLine();
            foreach (char letter in input.ToCharArray()) {
                if (letter == ' ') continue;
                string natoWord = natoAlphabet[Char.ToUpper(letter)];
                Console.Write(string.Format("{0} ", natoWord));
            }
            Console.WriteLine();
        }
    }
}
