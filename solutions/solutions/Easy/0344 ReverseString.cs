using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Solution_0344
    {
        public void ReverseString(char[] s)
        {
            if (s == null || s.Length == 0) return;

            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                var temp = s[i];
                s[i] = s[j];
                s[j] = temp;

                i++; j--;
            }
        }
    }
    public class _0344_ReverseString
    {
        public static void Test()
        {
            Solution_0344 solution = new Solution_0344();
            char[] data1 = new char[] { 'h', 'e', 'l', 'l', 'o' };
            char[] data2 = new char[] { 'H', 'a', 'n', 'n', 'a', 'h' };

            solution.ReverseString(data1);
            solution.ReverseString(data2);
       
            Console.WriteLine(data1);
            Console.WriteLine(data2);
        }
    }
}
