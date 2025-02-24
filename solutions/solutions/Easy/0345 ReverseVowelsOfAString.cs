using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Solution_0345
    {
        public string ReverseVowels(string s)
        {
            char[] word = s.ToCharArray();
            int start = 0;
            int end = s.Length - 1;
            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            while (start < end)
            {
                while (start < end && !vowels.Contains(word[start]))
                {
                    start++;
                }
                while (start < end && !vowels.Contains(word[end]))
                {
                    end--;
                }

                char temp = word[start];
                word[start] = word[end];
                word[end] = temp;

                start++;
                end--;
            }
            return new string(word);
        }
    }
    public class _0345_ReverseVowelsOfAString
    {
        public static void Test()
        {
            Solution_0345 solution = new Solution_0345();
            var s = "IceCreAm";
            var result = solution.ReverseVowels(s);
            Console.WriteLine(result);
        }
    }
}
