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

            int[] outputSimple = Leet_01_Two_Sum.TwoSumSimple(new int[] { 3, 2, 4 }, 6);
            Console.WriteLine($"Simple: {outputSimple[0]} , {outputSimple[1]}");

            int[] outputComplex = Leet_01_Two_Sum.TwoSumComplex(new int[] { 3,2,4 }, 6);
            Console.WriteLine($"Complex: {outputComplex[0]} , {outputComplex[1]}");
            Console.ReadLine();
        }
    }
}
