using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = num[col];
                }
            }
            string[] comand = Console.ReadLine().Split(" ");
            for (int i = 0; i < comand.Length; i++)
            {
                var com = comand[i].Split(",").Select(int.Parse).ToArray();
                var com1 = com[0];
                var com2 = com[1];
                var power = matrix[com1, com2];
                for (int z = com1 - 1; z <= com1 + 1; z++)
                {
                    for (int s = com2 - 1; s <= com2 + 1; s++)
                    {
                        if (z >= 0 && z < matrix.GetLength(0) && s >= 0 && s < matrix.GetLength(1))
                        {
                            if (matrix[z, s] <= 0 || power < 0)
                            {
                                continue;
                            }
                            matrix[z, s] -= power;
                        }
                    }
                }


            }
            int count = 0;
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int z = 0; z < matrix.GetLength(1); z++)
                {
                    if (matrix[i, z] > 0)
                    {
                        count++;
                        sum += matrix[i, z];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");
            for (int i = 0; i < n; i++)
            {
                for (int z = 0; z < n; z++)
                {
                    if (matrix[i, z] > 0)
                    {
                        count++;
                        sum += matrix[i, z];
                    }
                    Console.Write(matrix[i, z] + " ");
                }
                Console.WriteLine();
            }



        }
    }
}
