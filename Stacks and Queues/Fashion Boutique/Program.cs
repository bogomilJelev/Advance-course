using System;
using System.Collections.Generic;
using System.Linq;

namespace sealing
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> rack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());
            int sum = 0;
            int ask = 1;
            while (rack.Any())
            {
                if (rack.Peek() + sum <= capacity)
                {
                    sum += rack.Pop();
                }
                else if (rack.Peek() + sum > capacity)
                {
                    ask++;
                    sum = 0;
                    sum += rack.Pop();
                }
            }
            Console.WriteLine(ask);
        }


    }
}
