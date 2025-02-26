using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Solution_0415
    {
        public string AddStrings(string num1, string num2)
        {
            int carry = 0;
            int p1 = num1.Length - 1;
            int p2 = num2.Length - 1;
            StringBuilder result = new StringBuilder();

            while (p1 >= 0 || p2 >= 0)
            {
                int x1 = p1 >= 0 ? num1[p1] - '0' : 0;
                int x2 = p2 >= 0 ? num2[p2] - '0' : 0;

                int sum = x1 + x2 + carry;
                carry = sum / 10;
                result.Append(sum % 10);

                p1--;
                p2--;
            }

            if (carry > 0)
            {
                result.Append(carry);
            }

            char[] resultArray = result.ToString().ToCharArray();
            Array.Reverse(resultArray);
            return new string(resultArray);
        }
    }
    
    public class _0415_AddStrings
    {
        public static void Test()
        {
            Solution_0415 solution = new Solution_0415();

            Console.WriteLine(solution.AddStrings("24", "39"));
        }
    }
}
