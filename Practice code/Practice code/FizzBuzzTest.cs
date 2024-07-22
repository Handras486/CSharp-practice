using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_code
{
    public static class FizzBuzzTest
    {

        public static void  FizzBuzz()
        { 
            for (int i = 1; i <= 100; i++)
            {
                if ( i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ( i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                Console.WriteLine(i);
            }
        }
    }
}
