using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Solution_0205
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, char> firstString = new Dictionary<char, char>();
            Dictionary<char, char> secondString = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                char charStringS = s[i];
                char charStringT = t[i];

                if (firstString.ContainsKey(charStringS))
                {
                    if (firstString[charStringS] != charStringT)
                        return false;
                }
                else
                {
                    firstString[charStringS] = charStringT;
                }

                if (secondString.ContainsKey(charStringT))
                {
                    if (secondString[charStringT] != charStringS)
                        return false;
                }
                else
                {
                    secondString[charStringT] = charStringS;
                }
            }

            return true;
        }
    }
    public class _0205_IsomorphicStrings
    {
        public static void Test()
        {
            Solution_0205 solution = new Solution_0205();

            Console.WriteLine(solution.IsIsomorphic("egg", "add")); // true

            Console.WriteLine(solution.IsIsomorphic("foo", "bar")); // false

            Console.WriteLine(solution.IsIsomorphic("paper", "title")); // true
        }
    }
}
