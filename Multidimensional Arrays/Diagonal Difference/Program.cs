using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int z = 0; z < matrix.GetLength(1); z++)
                {
                    if (i == z)
                    {
                        sum1 += matrix[i, z];
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int count = matrix.GetLength(1) - 1 - i;

                sum2 += matrix[i, count];

            }
            Console.WriteLine($"{Math.Abs(sum1 - sum2)}");

        }

    }
}
