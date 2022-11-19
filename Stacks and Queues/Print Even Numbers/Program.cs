using System;
using System.Collections.Generic;
using System.Linq;

namespace Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ask = new Queue<int>();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    ask.Enqueue(numbers[i]);
                }
            }
            Console.Write(string.Join(", ", ask));


        }
    }
}
