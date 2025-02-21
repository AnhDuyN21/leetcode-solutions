using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Solution_0171
    {
        public int TitleToNumber(string columnTitle)
        {
            int result = 0;

            for (int i = 0; i < columnTitle.Length; i++)
            {
                // Tính giá trị của ký tự hiện tại
                int value = columnTitle[i] - 'A' + 1;

                // Cập nhật kết quả, dịch chuyển sang trái một vị trí (nhân với 26)
                result = result * 26 + value;
            }

            return result;
        }
    }
    public class _0171_ExcelSheetColumnNumber
    {
        public static void Test()
        {
            Solution_0171 solution = new Solution_0171();

            Console.WriteLine(solution.TitleToNumber("A")); // 1


            Console.WriteLine(solution.TitleToNumber("AB")); // 28


            Console.WriteLine(solution.TitleToNumber("ZY")); // 701
        }
    }
}
