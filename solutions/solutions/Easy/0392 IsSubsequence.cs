using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Solution_0392
    {
        public bool IsSubsequence(string s, string t)
        {
            int sIndex = 0, tIndex = 0;

            while (sIndex < s.Length && tIndex < t.Length)
            {
                if (s[sIndex] == t[tIndex])
                {
                    sIndex++;
                }
                tIndex++;
            }

            return sIndex == s.Length;
        }
    }
    public class _0392_IsSubsequence
    {
        public static void Test()
        {
            Solution_0392 solution = new Solution_0392();

            Console.WriteLine(solution.IsSubsequence("abc", "ahbgdc")); //true
            Console.WriteLine(solution.IsSubsequence("axc", "ahbgdc")); //false
        }
    }
}
