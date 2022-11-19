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
            string[,] matrix = new string[size, size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string numbers = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col].ToString();
                }
            }
            string serchelement = Console.ReadLine();
            bool isprint = true;


            for (int i = 0; i < size; i++)
            {
                for (int z = 0; z < size; z++)
                {
                    if (matrix[i, z] == serchelement)
                    {
                        if (!isprint == false)
                        {
                            Console.WriteLine($"({i}, {z})");
                            isprint = false;
                        }
                    }

                }
            }
            if (isprint)
            {
                Console.WriteLine($"{serchelement} does not occur in the matrix");
            }



        }

    }
}
