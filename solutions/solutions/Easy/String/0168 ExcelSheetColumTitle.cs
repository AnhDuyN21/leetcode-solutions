using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy.String
{
    public class Solution_0168 
    {
        public string ConvertToTitle(int columnNumber)
        {
            string result = string.Empty;
            while(columnNumber > 0)
            {
                columnNumber--;
                int remainder = columnNumber % 26;
                char letter = (char)('A' + remainder);
                result = letter + result;
                columnNumber /= 26;
            }
            return result;
        }
    }

    public class _0168_ExcelSheetColumTitle
    {
        public static void Test()
        {
            Solution_0168 solution = new Solution_0168();
            // Ví dụ 1
            int columnNumber1 = 1;
            string result1 = solution.ConvertToTitle(columnNumber1);
            Console.WriteLine($"Input: {columnNumber1}, Output: \"{result1}\""); // Output: "A"

            // Ví dụ 2
            int columnNumber2 = 28;
            string result2 = solution.ConvertToTitle(columnNumber2);
            Console.WriteLine($"Input: {columnNumber2}, Output: \"{result2}\""); // Output: "AB"

            // Ví dụ 3
            int columnNumber3 = 701;
            string result3 = solution.ConvertToTitle(columnNumber3);
            Console.WriteLine($"Input: {columnNumber3}, Output: \"{result3}\""); // Output: "ZY"
        }
    }
}
