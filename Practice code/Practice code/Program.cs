using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice_code
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 11;
            //int b = a;
            //b = 12;
            //Console.WriteLine($"{a} and {b}");

            //Hallgato h1 = new Hallgato() { Név = "Józsi" };
            //Hallgato h2 = h1;
            //h2.Név = "Pista";
            //Console.WriteLine($"{h1.Név} and {h2.Név}");

            //Dictionary.DictExample();

            //int[] outputSimple = Leet_01_Two_Sum.TwoSumSimple(new int[] { 3, 2, 4 }, 6);
            //Console.WriteLine($"Simple: {outputSimple[0]} , {outputSimple[1]}");

            //int[] outputComplex = Leet_01_Two_Sum.TwoSumComplex(new int[] { 3,2,4 }, 6);
            //Console.WriteLine($"Complex: {outputComplex[0]} , {outputComplex[1]}");

            //int[] outputhash = Leet_01_Two_Sum.TwoSumHashSet(new int[] { 3, 2, 4 }, 6);
            //Console.WriteLine($"HashSet: {outputhash[0]} , {outputhash[1]}");

            string s = "abba";
            int longestLengtht = Leet_03_LongestSubstringNoRepeat.LengthOfLongestSubstringSlidingWindow(s);
            Console.WriteLine($"Longest Substring length: {longestLengtht}");

            //string[] words = new string[] { "hrn", "hrf", "er", "enn", "rfnn" };
            //string result = Leet_269_Alien_Dictionary.AlienDictionary(words);
            //Console.WriteLine(result);

            string[] words2 = new string[] { "fxasxpc", "dfbdrifhp", "nwzgs", "cmwqriv", "ebulyfyve", "miracx", "sxckdwzv", "dtijzluhts", "wwbmnge", "qmjwymmyox" };
            string order = "zkgwaverfimqxbnctdplsjyohu";
            //bool isOrdered = Leet_953_Verify_Alien_Dictionary.IsAlienSorted(words2, order);
            bool isOrdered = Leet_953_Verify_Alien_Dictionary.IsAlienSortedDictionary(words2, order);
            Console.WriteLine(isOrdered);

            IList<string> combinations = Leet_17_Phone_Number_Letter_Combinations.LetterCombinations("23");
            foreach (string combination in combinations)
            {
                Console.WriteLine(combination);
            }

            char[][] board = new char[][]
            {
             new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' }
            ,new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'}
            ,new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'}
            ,new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'}
            ,new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'}
            ,new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'}
            ,new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'}
            ,new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'}
            ,new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
            };
            Console.WriteLine(Leet_36_Valid_Sudoku.IsValidSudoku(board));
            

            Console.ReadLine();
        }
    }
}
