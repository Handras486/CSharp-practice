using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_code
{

    //pain
    public class Leet_05_Longest_Palindromic_Substring
    {
        public string LongestPalindrome(string s)
        {
            HashSet<string> palindromes = new HashSet<string>();
            int max = 0;
            int i = 0;
            int range = 0;

            while (i < s.Length)
            {
                range++;
                if (0 >= i - range && i + range < s.Length)
                {

                }
                else
                {
                    range = 0;
                    i++;
                }
            }


            return "asd";
        }
    }
}
