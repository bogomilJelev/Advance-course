using System;

namespace sadd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int comandcount = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int frow = 0;
            int fcol = 0;
            bool iswon = true;
            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                    if (input[col] == 'f')
                    {
                        frow = row;
                        fcol = col;
                    }
                }
            }
            for (int i = 0; i < comandcount; i++)
            {
                matrix[frow, fcol] = '-';
                string comand = Console.ReadLine();
                frow = MoveUD(matrix, comand, frow);
                fcol = MoveRL(matrix, comand, fcol);
                //Console.WriteLine(matrix[4,1]);
                if (matrix[frow, fcol] == 'F')
                {
                    matrix[frow, fcol] = 'f';
                    Console.WriteLine("Player won!");
                    iswon = false;
                    break;
                }
                else if (matrix[frow, fcol] == 'T')
                {
                    if (comand == "left")
                    {
                        fcol++;
                    }
                    else if (comand == "right")
                    {
                        fcol--;
                    }
                    else if (comand == "up")
                    {
                        frow--;
                    }
                    else if (comand == "down")
                    {
                        frow++;
                    }
                    matrix[frow, fcol] = 'f';
                }
                else if (matrix[frow, fcol] == 'B')
                {
                    frow = MoveUD(matrix, comand, frow);
                    fcol = MoveRL(matrix, comand, fcol);
                    matrix[frow, fcol] = 'f';
                }
                else if (matrix[frow, fcol] == '-')
                {
                    matrix[frow, fcol] = 'f';
                }

            }
            if (iswon)
            {
                Console.WriteLine("Player lost!");
            }
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(matrix[r, c]);
                }
                Console.WriteLine();
            }
        }
        public static int MoveRL(char[,] mat, string comand, int col)
        {
            if (comand == "left")
            {
                col -= 1;
                if (col < 0)
                {
                    col = mat.GetLength(0) - 1;
                }
                return col;
            }
            else if (comand == "right")
            {
                col += 1;
                if (col > mat.GetLength(0) - 1)
                {
                    col = 0;
                }
            }
            return col;
        }
        public static int MoveUD(char[,] mat, string comand, int row)
        {
            if (comand == "up")
            {
                row -= 1;
                if (row < 0)
                {
                    row = mat.GetLength(1) - 1;
                }
                return row;
            }
            else if (comand == "down")
            {
                row += 1;
                if (row > mat.GetLength(1) - 1)
                {
                    row = 0;
                }
            }
            return row;
        }
    }
}
