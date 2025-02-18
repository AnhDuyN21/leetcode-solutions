using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy.String
{
    public class Solution58
    {
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            int lastSpaceIndex = s.LastIndexOf(' ');
            return s.Length - lastSpaceIndex - 1;
        }
    }

    public static class _0058LengthOfLastWord
    {
        public static void Test()
        {
            Solution58 solution = new Solution58();

            // Ví dụ 1
            string s1 = "Hello World";
            Console.WriteLine(solution.LengthOfLastWord(s1)); // Output: 5

            // Ví dụ 2
            string s2 = "   fly me   to   the moon  ";
            Console.WriteLine(solution.LengthOfLastWord(s2)); // Output: 4
        }
    }
}
