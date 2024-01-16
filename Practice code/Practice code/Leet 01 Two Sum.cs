using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_code
{
    public class Leet_01_Two_Sum
    {
        public static int[] TwoSumSimple(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int temp = nums[i] + nums[j];
                    if (temp == target)
                    {
                        return new int[] {i, j};
                    }
                }
            }
            return null;
        }

        public static int[] TwoSumComplex(int[] nums, int target)
        {
            Dictionary<int, int> numsDict = new Dictionary<int, int>();// = nums.ToDictionary(x => x);
            for (int i = 0; i < nums.Length; i++)
            {
                numsDict[i] = nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int needed = target - nums[i];

                if (numsDict.Any(x => x.Value == needed && x.Key != i))
                {
                    KeyValuePair<int,int> pair = numsDict.FirstOrDefault(x => x.Value == needed && x.Key != i);
                    return new int[] { i, pair.Key};
                }
            }

            return null;
        }
    }
}
