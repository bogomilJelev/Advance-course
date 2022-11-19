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
            HashSet<string> setone = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] ask = Console.ReadLine().Split();
                for (int s = 0; s < ask.Length; s++)
                {
                    setone.Add(ask[s]);
                }

            }
            Console.WriteLine(string.Join(" ", setone.OrderBy(x => x)));
        }
    }
}
