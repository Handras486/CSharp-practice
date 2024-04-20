using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_code
{
    public class Leet_03_LongestSubstringNoRepeat
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int longestLength = 0;
            int localLength = 0;
            int i = 0;
            int j = 0;
            Dictionary<char, char> uniqueChars = new Dictionary<char, char>();

            while (i < s.Length)
            {
                if (j < s.Length && !uniqueChars.ContainsKey(s[j]))
                {
                    uniqueChars.Add(s[j], s[j]);
                    localLength++;
                    if (localLength > longestLength)
                    {
                        longestLength = localLength;
                    }
                    j++;
                }
                else
                {
                    uniqueChars.Clear();
                    i++;
                    j = i;
                    localLength = 0;
                }
            }

            return longestLength;
        }

        public static int LengthOfLongestSubstringOptimal(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int max = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, i);
                    max = Math.Max(dict.Count, max);
                }
                else
                {
                    i = dict[c];
                    dict.Clear();
                }
            }
            return max;
        }

        public static int LengthOfLongestSubstringOptimal2(string s)
        {

            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            HashSet<char> hSet = new HashSet<char>();
            int max = 0;
            int i = 0;
            int j = 0;

            while (i < s.Length)
            {
                if (!hSet.Contains(s[i]))
                {
                    hSet.Add(s[i]);
                    i++;

                }
                else
                {
                    max = Math.Max(max, hSet.Count);
                    hSet.Remove(s[j]);
                    j++;
                }
            }
            max = Math.Max(max, hSet.Count);
            return max;
        }

        public static int LengthOfLongestSubstringSlidingWindow(string s)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            int max = 0;
            int left = 0;
            int right;

            for (right = 0; right < s.Length; right++)
            {
                char c = s[right];

                if (letters.ContainsKey(c))
                {
                    left = Math.Max(left, letters[c] + 1);
                }

                letters[c] = right;

                max = Math.Max(max, right - left + 1);
            }
            return max;
        }
    }
}
