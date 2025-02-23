using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Solution_0541
    {
        public string ReverseStr(string s, int k)
        {
            char[] chars = s.ToCharArray();

            for (int i = 0; i < s.Length - 1; i += 2 * k)
            {
                var start = i;
                var end = Math.Min(i + k - 1, s.Length - 1);
                while (start < end)
                {
                    char temp = chars[start];
                    chars[start] = chars[end];
                    chars[end] = temp;
                    start++;
                    end--;
                }
            }
            return new string(chars);
        }
    }
    public class _0541_ReverseStringII
    {
        public static void Test()
        {
            Solution_0541 solution = new Solution_0541();
            string data1 = "abcdefg";
            string data2 = "abcd";

            Console.WriteLine(solution.ReverseStr(data1, 2));
            Console.WriteLine(solution.ReverseStr(data2, 2));
        }
    }
}
