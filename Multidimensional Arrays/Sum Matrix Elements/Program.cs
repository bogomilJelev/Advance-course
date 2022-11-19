using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[input[0], input[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputmatrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputmatrix[col];
                }
            }
            int sum = 0;
            for (int row1 = 0; row1 < matrix.GetLength(0); row1++)
            {
                for (int col1 = 0; col1 < matrix.GetLength(1); col1++)
                {

                    sum += matrix[row1, col1];
                }

            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);


        }

    }
}
