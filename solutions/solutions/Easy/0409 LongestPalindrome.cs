using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Solution_0409
    {
        public int LongestPalindrome(string s)
        {
            int[] charCounts = new int[128]; // Sử dụng mảng để đếm số lần xuất hiện của các ký tự (ASCII)
            foreach (char c in s)
            {
                charCounts[c]++;
            }

            int length = 0;
            bool oddCountExists = false;

            foreach (int count in charCounts)
            {
                if (count % 2 == 0)
                {
                    length += count; // Số lần chẵn có thể dùng hết
                }
                else
                {
                    length += count - 1; // Số lần lẻ có thể dùng số lần - 1
                    oddCountExists = true; // Đánh dấu có ký tự xuất hiện số lần lẻ
                }
            }

            // Nếu có ít nhất một ký tự xuất hiện số lần lẻ, thêm 1 vào độ dài của palindrome
            if (oddCountExists)
            {
                length++;
            }

            return length;
        }
    }
    public class _0409_LongestPalindrome
    {
        public static void Test()
        {
            Solution_0409 solution = new Solution_0409();

            Console.WriteLine(solution.LongestPalindrome("abccccdd")); // 7
            Console.WriteLine(solution.LongestPalindrome("a")); // 1
        }
    }
}
