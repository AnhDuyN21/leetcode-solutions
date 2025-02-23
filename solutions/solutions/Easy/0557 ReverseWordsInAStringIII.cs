using Leetcode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Solution_0557
    {
        public string ReverseWords(string s)
        {
            string[] words = s.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] word = words[i].ToCharArray();
                Array.Reverse(word);
                words[i] = new string(word);
            }
            return string.Join(" ", words);
        }
    }
}
    public class _0557_ReverseWordsInAStringIII
    {
        public static void Test()
        {
            Solution_0557 solution = new Solution_0557();

            var input = "Let's take LeetCode contest";

            Console.WriteLine(solution.ReverseWords(input));
        }

        
}
