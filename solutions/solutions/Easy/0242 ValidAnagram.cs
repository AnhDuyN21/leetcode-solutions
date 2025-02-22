using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Solution_0242
    {
        public bool IsAnagram(string s, string t)
        {
            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();
            Array.Sort(sArray);
            Array.Sort(tArray);
            string sortedS = new string(sArray);
            string sortedT = new string(tArray);
            if (sortedS == sortedT)
            {
                return true;
            }
            return false;
        }
    }
    public class _0242_ValidAnagram
    {
        public static void Test()
        {
            Solution_0242 solution = new Solution_0242();

            Console.WriteLine(solution.IsAnagram("anagram", "nagaram")); // true

            Console.WriteLine(solution.IsAnagram("rat", "car")); // false
        }   
    }
}
