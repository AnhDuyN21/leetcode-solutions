using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Solution1
    {
        public int RemoveElement(int[] nums, int val)
        {
            int total = 0;
            foreach (int i in nums)
            {
                if(i != val)
                {
                    nums[total] = i;
                    total++;
                }

            }
            return total;
        }
    }

    public static class _0027RemoveElement
    {
        private static List<int[]> Inputs = new List<int[]>()
    {
        new int[] {3,2,2,3},
        new int[] {0,1,2,2,3,0,4,2},
    };
        private static List<int> Vals = new List<int>() { 3, 2 };
        private static List<int> ExpectedOutputs = new List<int>() { 2, 5 };

        public static void Test()
        {
            var solution = new Solution1();

            for (int i = 0; i < Inputs.Count; i++)
            {
                var input = Inputs[i];
                var val = Vals[i];
                var expectedOutput = ExpectedOutputs[i];

                var actualOutput = solution.RemoveElement(input, val);
                Console.WriteLine($"Input: {string.Join(',', input)}, Val: {val}, Expected Output: {expectedOutput}, Actual Output: {actualOutput}");
            }
        }
    }
}
