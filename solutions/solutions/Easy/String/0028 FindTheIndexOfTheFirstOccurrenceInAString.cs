using System;
using System.Text;

namespace Leetcode.Easy.String
{
    public class Solution28
    {
        public int StrStr(string haystack, string needle)
        {
            int index = haystack.IndexOf(needle);

            return index;
        }
    }

    public static class _0028_FindTheIndexOfTheFirstOccurrenceInAString
    {
        public static void Test()
        {
            // Thiết lập mã hóa của console sang UTF-8
            Console.OutputEncoding = Encoding.UTF8;

            Solution28 solution = new Solution28();

            // Nhập chuỗi haystack từ người dùng
            Console.WriteLine("Nhập chuỗi haystack:");
            string haystack = Console.ReadLine();

            // Nhập chuỗi needle từ người dùng
            Console.WriteLine("Nhập chuỗi needle:");
            string needle = Console.ReadLine();

            // Tìm và hiển thị kết quả
            int result = solution.StrStr(haystack, needle);
            Console.WriteLine("Vị trí xuất hiện đầu tiên của needle trong haystack là: " + result);
        }
    }
    //Đề: cho 2 chuỗi string "haystack" và "needle" trả về vị trí xuất 
    //    hiện đầu tiên của needle trong haystack nếu không có giá trị sẽ là -1
 //Ví dụ: Input: haystack = "sadbutsad", needle = "sad"
    //    Output: 0
    //    Explanation: "sad" occurs at index 0 and 6.
    //    The first occurrence is at index 0, so we return 0.
}
