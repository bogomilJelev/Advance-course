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
            string[,] matrix = new string[n, n];
            int srow = 0;
            int scol = 0;
            bool iseaten = false;
            int food = 0;
            for (int row = 0; row < n; row++)
            {
                string ask = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = ask[col].ToString();
                    if (ask[col] == 'S')
                    {
                        srow = row;
                        scol = col;
                    }
                }
            }
            while (true)
            {
                if (food == 10)
                {
                    iseaten = true;
                    break;
                }
                string comand = Console.ReadLine();
                matrix[srow, scol] = ".";
                srow = MoveUD(comand, srow);
                scol = MoveLR(comand, scol);
                if (!IsValid(srow, scol, n, n))
                {
                    Console.WriteLine("Game over!");
                    break;
                }
                if (matrix[srow, scol] == "B")
                {
                    matrix[srow, scol] = ".";
                    for (int row = 0; row < n; row++)
                    {
                        bool sak = false;
                        for (int col = 0; col < n; col++)
                        {
                            if (matrix[row, col] == "B")
                            {
                                scol = col;
                                srow = row;
                                matrix[srow, scol] = "S";
                                sak = true;
                                break;
                            }
                        }
                        if (sak)
                        {
                            break;
                        }
                    }
                }
                else if (matrix[srow, scol] == "*")
                {
                    matrix[srow, scol] = "S";
                    food++;

                }
                else
                {
                    matrix[srow, scol] = "S";
                }

            }
            if (iseaten)
            {
                Console.WriteLine("You won! You fed the snake.");
            }
            Console.WriteLine($"Food eaten: {food}");
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
