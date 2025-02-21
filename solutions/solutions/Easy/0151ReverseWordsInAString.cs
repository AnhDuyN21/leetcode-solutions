using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Solution_0151
    {
        public string ReverseWords(string s)
        {
            string result = string.Empty;
            string[] array = s.Split(new char[] { ' ', ';', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(array);
            //int start = 0;
            //int end = array.Length - 1;
            //while (start < end)
            //{
            //    string temp = array[start];
            //    array[start] = array[end];
            //    array[end] = temp;
            //    start++;
            //    end--;
            //}
            result = string.Join(" ", array);


            return result;
        }
    }
    public class _0151ReverseWordsInAString
    {
        public static void Test()
        {
            Solution_0151 solution = new Solution_0151();
            string s = "  hello world  ";
            solution.ReverseWords(s);
            Console.WriteLine($"Input: {s}, Output: \"{solution.ReverseWords(s)}\""); // Output: "blue is sky the"
        }
    }
}
