using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Interview.NashTech
{
    public class Solution_NashTech_Problem_3
    {
        #region Đề bài
        //viết chương trình để xoay một ma trận N x N 90 độ theo chiều kim đồng hồ.

        //Đề bài:
        //Viết chương trình để xoay một ma trận N x N 90 độ theo chiều kim đồng hồ.

        //Đầu vào:

        //Dòng đầu tiên sẽ chỉ định kích thước N của ma trận.

        //Tiếp theo là N dòng chứa các phần tử của ma trận.

        //Đầu ra:

        //In ra ma trận sau khi xoay 90 độ theo chiều kim đồng hồ.
        #endregion
        public void RotateMatrix(int N, int[,] matrix)
        {
            for (int x = 0; x < N / 2; x++)
            {
                for (int y = x; y < N - x - 1; y++)
                {
                    int temp = matrix[x, y];

                    matrix[x, y] = matrix[N - 1 - y, x];
                    matrix[N - 1 - y, x] = matrix[N - 1 - x, N - 1 - y];
                    matrix[N - 1 - x, N - 1 - y] = matrix[y, N - 1 - x];
                    matrix[y, N - 1 - x] = temp;
                }
            }
        }

        public void PrintMatrix(int N, int[,] matrix)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
    public class Problem3
    {
        public static void Test()
        {
            Solution_NashTech_Problem_3 solution = new Solution_NashTech_Problem_3();
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Nhập kích thước N của ma trận: ");
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];

            Console.WriteLine("Nhập ma trận:");
            for (int i = 0; i < N; i++)
            {
                string[] row = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = int.Parse(row[j]);
                }
            }

            solution.RotateMatrix(N, matrix);

            Console.WriteLine("Ma trận sau khi xoay 90 độ theo chiều kim đồng hồ:");
            solution.PrintMatrix(N, matrix);

        }
    }
}
