using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_code
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary.DictExample();

            //int[] outputSimple = Leet_01_Two_Sum.TwoSumSimple(new int[] { 3, 2, 4 }, 6);
            //Console.WriteLine($"Simple: {outputSimple[0]} , {outputSimple[1]}");

            //int[] outputComplex = Leet_01_Two_Sum.TwoSumComplex(new int[] { 3,2,4 }, 6);
            //Console.WriteLine($"Complex: {outputComplex[0]} , {outputComplex[1]}");

            //string s = "pwwkew";
            //int longestLengtht = Leet_03_LongestSubstringNoRepeat.LengthOfLongestSubstringOptimal2(s);
            //Console.WriteLine($"Longest Substring length: {longestLengtht}");

            //string[] words = new string[] { "hrn", "hrf", "er", "enn", "rfnn" };
            //string result = Leet_269_Alien_Dictionary.AlienDictionary(words);
            //Console.WriteLine(result);

            string[] words2 = new string[] { "fxasxpc", "dfbdrifhp", "nwzgs", "cmwqriv", "ebulyfyve", "miracx", "sxckdwzv", "dtijzluhts", "wwbmnge", "qmjwymmyox" };
            string order = "zkgwaverfimqxbnctdplsjyohu";
            //bool isOrdered = Leet_953_Verify_Alien_Dictionary.IsAlienSorted(words2, order);
            bool isOrdered = Leet_953_Verify_Alien_Dictionary.IsAlienSortedDictionary(words2, order);
            Console.WriteLine(isOrdered);

            Console.ReadLine();
        }
    }
}
