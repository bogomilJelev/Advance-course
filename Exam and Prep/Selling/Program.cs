using System;

namespace sealing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int Srow = 0;
            int Scol = 0;
            int sum = 0;
            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                    if (input[col] == 'S')
                    {
                        Srow = row;
                        Scol = col;
                    }
                }

            }
            while (true)
            {
                matrix[Srow, Scol] = '-';
                string comand = Console.ReadLine();
                Srow = MoveUD(comand, Srow);
                Scol = MoveLR(comand, Scol);
                if (Isvalid(matrix, Srow, Scol))
                {
                    if (matrix[Srow, Scol] == 'O')
                    {
                        matrix[Srow, Scol] = '-';
                        for (int r = 0; r < n; r++)
                        {
                            for (int c = 0; c < n; c++)
                            {
                                if (matrix[r, c] == 'O')
                                {
                                    Srow = r;
                                    Scol = c;

                                }
                            }
                        }
                        matrix[Srow, Scol] = 'S';
                    }
                    else if (matrix[Srow, Scol] == '-')
                    {
                        matrix[Srow, Scol] = 'S';
                    }
                    else
                    {
                        int ask = int.Parse(matrix[Srow, Scol].ToString());
                        matrix[Srow, Scol] = 'S';
                        sum += ask;
                    }
                }
                else
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    break;
                }
                if (sum >= 50)
                {
                    Console.WriteLine("Good news! You succeeded in collecting enough money!"); ;
                    break;
                }
            }
            Console.WriteLine($"Money: {sum}");
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(matrix[r, c]);
                }
                Console.WriteLine();
            }

        }
        public static int MoveLR(string com, int col)
        {
            if (com == "left")
            {
                col -= 1;
            }
            else if (com == "right")
            {
                col += 1;
            }
            return col;
        }
        public static int MoveUD(string com, int row)
        {
            if (com == "up")
            {
                row -= 1;
            }
            else if (com == "down")
            {
                row += 1;
            }
            return row;
        }
        public static bool Isvalid(char[,] matrix, int row, int col)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }
    }
}
