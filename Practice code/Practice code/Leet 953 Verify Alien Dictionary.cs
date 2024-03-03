using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_code
{
    internal class Leet_953_Verify_Alien_Dictionary
    {
        public static bool IsAlienSorted(string[] words, string order)
        {
            for (int i = 0; i < words.Length - 1; i++)
            {
                string w1 = words[i];
                string w2 = words[i + 1];

                int minlength = Math.Min(w1.Length, w2.Length);

                if (w1.Length > w2.Length && w1.Substring(0, minlength) == w2.Substring(0, minlength))
                    return false;

                for (int j = 0; j < minlength; j++)
                {
                    if (order.IndexOf(w1[j]) < order.IndexOf(w2[j]))
                    {
                        break;
                    }
                    else if (order.IndexOf(w1[j]) > order.IndexOf(w2[j]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool IsAlienSortedDictionary(string[] words, string order)
        {
            Dictionary<char, int> ordermap = order.ToDictionary(x => x, x => order.IndexOf(x)) ;

            for (int i = 0; i < words.Length - 1; i++)
            {
                string w1 = words[i];
                string w2 = words[i + 1];

                int minlength = Math.Min(w1.Length, w2.Length);

                if (w1.Length > w2.Length && w1.Substring(0, minlength) == w2.Substring(0, minlength))
                    return false;

                for (int j = 0; j < minlength; j++)
                {
                    if (ordermap[w1[j]] < ordermap[w2[j]])
                    {
                        break;
                    }
                    else if (ordermap[w1[j]] > ordermap[w2[j]])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
