using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Solution_0387
    {
        public int FirstUniqChar(string s)
        {            
            char[] words = s.ToCharArray();
            Dictionary<char,int> dic = new Dictionary<char,int>();
            for(int i = 0; i < words.Length; i++)
            {
                if (dic.ContainsKey(words[i]))
                {
                    dic[words[i]]++;
                }
                else
                {
                    dic.Add(words[i], 1);
                }
            }

            for(int i = 0; i < words.Length; i++)
            {
                if (dic[words[i]] == 1)
                {
                    return i;
                }
            }


            return -1;
        }
    }
    public class _0387_FirstUniqueCharacterInAString
    {
        public static void Test()
        {
            Solution_0387 solution = new Solution_0387();

            Console.WriteLine(solution.FirstUniqChar("leetcode")); // 0
            Console.WriteLine(solution.FirstUniqChar("loveleetcode")); // 2
            Console.WriteLine(solution.FirstUniqChar("aabb")); // -1

        }
    }
}
