using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Solution_0290
    {
        public bool WordPattern(string pattern, string s)
        {
            string[] words = s.Split(' ');
            if(pattern.Length != words.Length)
            {
                return false;
            }
            Dictionary<char, string> dic = new Dictionary<char, string>();
            for(int i = 0; i<pattern.Length; i++)
            {
                if (dic.ContainsKey(pattern[i])){
                    if (dic[pattern[i]] != words[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (!dic.ContainsValue(words[i])){
                        dic.Add(pattern[i], words[i]);
                    }
                    else
                    {
                        return false;
                    }
                    
                    
                }
            }
            return true;
        }
    }
    public class _0290_WordPattern
    {
        public static void Test()
        {
            Solution_0290 solution = new Solution_0290();

            Console.WriteLine(solution.WordPattern("abba", "dog dog dog dog")); // false
            Console.WriteLine(solution.WordPattern("abba", "dog cat cat dog")); // true
            Console.WriteLine(solution.WordPattern("abba", "dog cat cat fish")); // false
            
        }
    }
}
