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
            HashSet<int> setone = new HashSet<int>();
            HashSet<int> setsecond = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                int s = int.Parse(Console.ReadLine());
                if (setone.Contains(s))
                {
                    setsecond.Add(s);
                }
                else
                {
                    setone.Add(s);
                }
            }
            Console.WriteLine(string.Join("", setsecond));


        }
    }
}
