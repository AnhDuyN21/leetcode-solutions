using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy.String
{
    public class Solution125
    {
        public bool IsPalindrome(string s)
        {
            // Chuyển tất cả các ký tự thành chữ thường và loại bỏ các ký tự không phải là chữ cái và số
            string cleanedString = "";
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    cleanedString += char.ToLower(c);
                }
            }

            // Kiểm tra xem chuỗi đã được làm sạch có phải là palindrome hay không
            int left = 0;
            int right = cleanedString.Length - 1;
            while (left < right)
            {
                if (cleanedString[left] != cleanedString[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
        //Cách 2
        public bool IsPalindrome2(string s)
        {
            List<char> charList = new List<char>();

            foreach (char c in s.ToCharArray())
            {
                if (Char.IsLetter(c) || Char.IsDigit(c))
                {
                    charList.Add(c);
                }
            }
            
            string str = new string(charList.ToArray()).ToLower();

            string revStr = new string(charList.AsEnumerable().Reverse().ToArray()).ToLower();

            return revStr == str;
        }
    }
    public static class _0125_Valid_Palindrome
    {
        public static void Test()
        {
            Solution125 solution = new Solution125();

            // Ví dụ 1
            string s1 = "A man, a plan, a canal: Panama";
            Console.WriteLine(solution.IsPalindrome2(s1)); // Output: true

            // Ví dụ 2
            string s2 = "race a car";
            Console.WriteLine(solution.IsPalindrome2(s2)); // Output: false

            // Ví dụ 3
            string s3 = " ";
            Console.WriteLine(solution.IsPalindrome2(s3)); // Output: true
        }
    }
}
