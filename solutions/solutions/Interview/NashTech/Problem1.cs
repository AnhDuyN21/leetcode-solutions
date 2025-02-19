

namespace Leetcode.Interview.NashTech
{
    #region Đề bài
    // At NashTech, we have two groups of staff:
    //Software Development - staff Code SDxxxx(prefix SD, xxxx is length of 4, e.g.SD0123).
    //Business Process Operation - staff code BPOxxxx(prefix BPO, xxxx is length of 4, e.g.BPO0123).
    //Your task is to write a function to sum up how many staff belong to Software Development and how many staff belong to Business Process Operation
    //Note: The input contains a string of staff codes separated by commas or semicolons.

    //Input
    //SD0123, BPO4567; SD1234,BPO1111;SD222,BPO5678;BPO4568;SD3465

    //Output
    //SD: 3 BPO: 3

    //Notes
    //Valid staff code: SD0123, BPO9876
    //Invalid staff code: SD123, BPO987
    //Do not count duplicated staff code
    #endregion

    public class Solution_NashTech_Problem_1
    {
        public (int SDCount, int BPOCount) StaffCounting(string input)
        {
            // TODO: Let' rock 'n roll here
            int SDCount = 0;
            int BPOCount = 0;
            List<string> newInput = new List<string>();

            var inputAfterSplit = input.Split(new char[] { ',', ';' });
            foreach (var code in inputAfterSplit)
            {
                if (code.StartsWith("SD") && code.Length == 6 && !newInput.Contains(code))
                {
                    SDCount++;
                    newInput.Add(code);
                }
                else if (code.StartsWith("BPO") && code.Length == 7 && !newInput.Contains(code))
                {
                    BPOCount++;
                    newInput.Add(code);
                }
            }

            return (SDCount, BPOCount);
        }
    }

    public static class Problem1
    {
        public static void Test()
        {
            Solution_NashTech_Problem_1 solution = new Solution_NashTech_Problem_1();

            string input = "SD0123,BPO4567;SD0123,BPO1111;SD222,BPO5678;BPO4568;SD3465";

            var result = solution.StaffCounting(input);

            Console.WriteLine("SD: " + result.SDCount);
            Console.WriteLine("BPO: " + result.BPOCount);
        }
    }
}
