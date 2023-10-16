using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Two_Given_Integer
{
    internal class Program
    {
        public static string ExchangeFirstAndLastCharacters(string str)
        {
            if (str.Length <= 1)
            {
                return str;
            }

            char firstCharacter = str[0];
            char lastCharacter = str[str.Length - 1];

            string newString = str.Substring(1, str.Length - 2);

            return lastCharacter + newString + firstCharacter;
        }
        static void Main(string[] args)
        {

            string[] inputStrings = { "abcd", "a", "xy" };

            foreach (string inputString in inputStrings)
            {
                string newString = ExchangeFirstAndLastCharacters(inputString);
                Console.WriteLine($"The new string for {inputString} is {newString}");
                Console.ReadLine();

            }
        }
    }
}
