using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_code
{
    public class Leet_17_Phone_Number_Letter_Combinations
    {
        public static IList<string> LetterCombinations(string digits)
        {

            Dictionary<char, string> phone = new Dictionary<char, string> {
            {'2', "abc"}, {'3', "def"}, {'4', "ghi"}, {'5', "jkl"},
            {'6', "mno"}, {'7', "pqrs"}, {'8', "tuv"}, {'9', "wxyz"}
            };

            List<string> results = new List<string>();

            if (digits.Length == 0) return results;

            Search("", digits, 0, phone, results);

            return results;
        }

        private static void Search(string combination, string digits, int index, Dictionary<char, string> phone, List<string> results)
        {
            if (index == digits.Length)
            {
                results.Add(combination);
                return;
            }
            string letters = phone[digits[index]];
            foreach (char letter in letters)
            {
                Search(combination + letter, digits, index + 1, phone, results);
            }

        }
    }
}
