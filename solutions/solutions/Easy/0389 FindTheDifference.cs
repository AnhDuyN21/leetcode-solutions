using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Solution_0389
    {
        public char FindTheDifference(string s, string t)
        {
            int[] charCounts = new int[26]; // Chỉ cần 26 ký tự trong bảng chữ cái tiếng Anh

            // Đếm số lần xuất hiện của các ký tự trong chuỗi s
            foreach (char c in s)
            {
                charCounts[c - 'a']++;
            }

            // Giảm số lần xuất hiện của các ký tự trong chuỗi t
            foreach (char c in t)
            {
                charCounts[c - 'a']--;
            }

            // Tìm ký tự có giá trị đếm âm
            for (int i = 0; i < charCounts.Length; i++)
            {
                if (charCounts[i] < 0)
                {
                    return (char)(i + 'a');
                }
            }

            // Trường hợp mặc định, không bao giờ xảy ra vì bài toán đảm bảo có một ký tự thêm
            return '\0';
        }
    }
    public class _0389_FindTheDifference
    {
        public static void Test()
        {
            Solution_0389 solution = new Solution_0389();

            Console.WriteLine(solution.FindTheDifference("abcd", "abcde")); // e
            Console.WriteLine(solution.FindTheDifference("", "y")); // y
        }
    }
}
