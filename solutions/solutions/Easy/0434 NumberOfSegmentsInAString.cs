using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Solution_0434
    {
        public int CountSegments(string s)
        {
            var result = 0;
            var counterOn = true;
            for (var i = 0; i < s.Length; i++)
            {
                var item = s[i];
                if (item == ' ')
                {
                    counterOn = true;
                }
                else if (counterOn)
                {
                    result++;
                    counterOn = false;
                }
            }

            return result;
        }
    }
    public class _0434_NumberOfSegmentsInAString
    {
        public static void Test()
        {
            Solution_0434 solution = new Solution_0434();

            Console.WriteLine(solution.CountSegments("Hello, my name is John")); // 5
            Console.WriteLine(solution.CountSegments("Hello")); // 1
        }
    }
}
