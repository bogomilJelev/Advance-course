using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[n[0], n[1]];
            for (int row = 0; row < n[0]; row++)
            {
                for (int col = 0; col < n[1]; col++)
                {
                    matrix[row, col] = 0;
                }
            }
            string[] comand = Console.ReadLine().Split();
            while (true)
            {
                if (comand[0] == "Bloom")
                {
                    break;
                }
                else
                {
                    int com = int.Parse(comand[0]);
                    int com2 = int.Parse(comand[1]);
                    if (n[0] > com && com >= 0 && n[1] > com2 && com2 >= 0)
                    {
                        matrix[com, com2] = 1;

                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates.");

                        comand = Console.ReadLine().Split();
                        continue;
                    }
                }
                comand = Console.ReadLine().Split();
            }
            int[,] matrix2 = new int[n[0], n[1]];
            for (int row2 = 0; row2 < n[0]; row2++)
            {
                for (int col2 = 0; col2 < n[1]; col2++)
                {
                    matrix2[row2, col2] = matrix[row2, col2];
                }
            }
            for (int row = 0; row < n[0]; row++)
            {
                for (int col = 0; col < n[1]; col++)
                {
                    if (matrix[row, col] == 1)
                    {
                        for (int i = row + 1; i < n[0]; i++)
                        {
                            matrix2[i, col] += 1;
                        }
                        for (int i = row - 1; i >= 0; i--)
                        {
                            matrix2[i, col] += 1;
                        }
                        for (int i = col + 1; i < n[1]; i++)
                        {
                            matrix2[row, i] += 1;
                        }
                        for (int i = col - 1; i >= 0; i--)
                        {
                            matrix2[row, i] += 1;
                        }
                    }
                }
            }
            for (int row = 0; row < n[0]; row++)
            {
                for (int col = 0; col < n[1]; col++)
                {
                    matrix[row, col] = matrix2[row, col];
                }
            }
            for (int row = 0; row < n[0]; row++)
            {
                for (int col = 0; col < n[1]; col++)
                {
                    Console.Write($"{matrix2[row, col] + " "}");
                }
                Console.WriteLine();
            }
        }
    }
}



