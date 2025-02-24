using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Solution_0383
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> charsCount = new Dictionary<char, int>();
            foreach(char c in magazine)
            {
                if(charsCount.ContainsKey(c))
                {
                    charsCount[c]++;
                }
                else
                {
                    charsCount.Add(c, 1);
                }
            }
            for(int i = 0; i < ransomNote.Length; i++)
            {
                if (charsCount.ContainsKey(ransomNote[i]) && charsCount[ransomNote[i]] > 0)
                {
                    charsCount[ransomNote[i]]--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
    public class _0383_RansomNote
    {
        public static void Test()
        {
            Solution_0383 sol = new Solution_0383();
            Console.WriteLine(sol.CanConstruct("a", "b"));
            Console.WriteLine(sol.CanConstruct("aa", "ab"));
            Console.WriteLine(sol.CanConstruct("aa", "aab"));
        }
    }
}
