using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class Solution_006
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;

            StringBuilder[] sb = new StringBuilder[numRows];
            int currentRow = 0, direction = 1;
            for (int i = 0; i < sb.Length; i++)
            {
                sb[i] = new StringBuilder();
            }

            for (int i = 0; i < s.Length; i++)
            {
                sb[currentRow].Append(s[i]);
                if (currentRow == numRows - 1)
                    direction = -1;
                else if (currentRow == 0)
                    direction = 1;
                currentRow = currentRow + direction;
            }

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < numRows; i++)
                result.Append(sb[i]);

            return result.ToString();
        }
    }
    public class _0006_ZigzagConversion
    {
        public static void Test()
        {
            Solution_006 solution = new Solution_006();
            // Ví dụ 1
            string s1 = "PAYPALISHIRING";
            int numRows1 = 3;
            Console.WriteLine(solution.Convert(s1, numRows1)); // Output: "PAHNAPLSIIGYIR"

            // Ví dụ 2
            string s2 = "PAYPALISHIRING";
            int numRows2 = 4;
            Console.WriteLine(solution.Convert(s2, numRows2)); // Output: "PINALSIGYAHRPI"

            // Ví dụ 3
            string s3 = "A";
            int numRows3 = 1;
            Console.WriteLine(solution.Convert(s3, numRows3)); // Output: "A"
        }
    }
}
