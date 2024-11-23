using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Solution14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                string currentPrefix = string.Empty;

                for (int j = 0; j < strs[i].Length; j++)
                {
                    if (j >= prefix.Length) break;

                    if (strs[i][j] == prefix[j])
                    {
                        currentPrefix += strs[i][j];
                    }
                    else
                    {
                        break;
                    }

                }

                prefix = currentPrefix;
            }

            return prefix;
        }
    }

    public static class _0014LongestCommonPrefix
    {
        private static List<string[]> Inputs = new List<string[]> {
        new string[] { "flower", "flow", "flight" },
        new string[] { "dog","racecar","car" },
    };
        private static List<string> ExpectedOutputs = new List<string>() { "fl", "" };

        public static void Test()
        {
            var solution = new Solution14();

            foreach (var (input, expectedOutput) in Inputs.Zip(ExpectedOutputs))
            {
                var actualOutput = solution.LongestCommonPrefix(input);
                Console.WriteLine($"Input: {input}, Expected Output: {expectedOutput}, Actual Output: {actualOutput}");
            }
        }
    }
}
