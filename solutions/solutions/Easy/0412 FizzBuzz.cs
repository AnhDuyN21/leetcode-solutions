using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Solution_0412
    {
        public IList<string> FizzBuzz(int n)
        {
            IList<string> results = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if( i % 3 == 0 && i % 5 == 0)
                {
                    results.Add("FizzBuzz");
                }else if( i % 5 == 0)
                {
                    results.Add("Buzz");
                }else if( i % 3 == 0)
                {
                    results.Add("Fizz");
                }
                else
                {
                    results.Add(i.ToString());
                }
            }
            PrintFizzBuzz(results);
            return results;
        }
        public void PrintFizzBuzz(IList<string> result)
        {
            Console.WriteLine("[" + string.Join(", ", result) + "]");
        }
    }
    public class _0412_FizzBuzz
    {
        public static void Test()
        {
            Solution_0412 solution = new Solution_0412();

            solution.FizzBuzz(3);  // Output: ["1", "2", "Fizz"]
            solution.FizzBuzz(5);  // Output: ["1", "2", "Fizz", "4", "Buzz"]
            solution.FizzBuzz(15); // Output: ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"]
        }
    }
}
