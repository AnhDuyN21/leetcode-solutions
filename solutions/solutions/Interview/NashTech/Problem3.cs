using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
        public void RotateMatrix(int N,int M, int[,] matrix)
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

        public void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
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

            int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6}
        };

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] rotatedMatrix = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    rotatedMatrix[j, rows - 1 - i] = matrix[i, j];
                }
            }

            solution.PrintMatrix(rotatedMatrix);

        }
    }
}
