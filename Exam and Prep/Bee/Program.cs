using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int rowbee = 0;
            int colbee = 0;
            int flower = 0;

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row, col] == 'B')
                    {
                        rowbee = row;
                        colbee = col;
                    }
                }
            }
            string comand = Console.ReadLine();
            while (comand != "End")
            {
                matrix[rowbee, colbee] = '.';
                rowbee = MoveUD(comand, rowbee);
                colbee = MoveLR(comand, colbee);
                if (!IsValid(rowbee, colbee, n, n))
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }
                if (matrix[rowbee, colbee] == 'f')
                {
                    matrix[rowbee, colbee] = '.';
                    flower++;
                }
                if (matrix[rowbee, colbee] == 'O')
                {
                    matrix[rowbee, colbee] = '.';
                    rowbee = MoveUD(comand, rowbee);
                    colbee = MoveLR(comand, colbee);
                    if (!IsValid(rowbee, colbee, n, n))
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }
                    if (matrix[rowbee, colbee] == 'f')
                    {
                        matrix[rowbee, colbee] = '.';
                        flower++;
                    }


                }
                matrix[rowbee, colbee] = 'B';
                comand = Console.ReadLine();
            }
            if (flower < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - flower} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flower} flowers!");
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

        }
        static int MoveUD(string com, int row)
        {
            if (com == "up")
            {
                row--;
            }
            else if (com == "down")
            {
                row++;
            }
            return row;
        }

        static bool IsValid(int row, int col, int rows, int cols)
        {
            if (row >= 0 && row <= rows - 1 && col >= 0 && col <= cols - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static int MoveLR(string com, int col)
        {
            if (com == "left")
            {
                col--;
            }
            else if (com == "right")
            {
                col++;
            }
            return col;
        }


    }
}
