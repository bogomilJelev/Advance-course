using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] leng = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> setone = new HashSet<int>();
            HashSet<int> setsecond = new HashSet<int>();
            FillSets(setone, leng[0]);
            FillSets(setsecond, leng[1]);
            Chekedset(setone, setsecond);
        }

        static void Chekedset(HashSet<int> setone, HashSet<int> setsecond)
        {
            List<int> ask = new List<int>();
            foreach (int numbers in setone)
            {
                if (setsecond.Contains(numbers))
                {
                    ask.Add(numbers);
                }
            }
            Console.WriteLine(string.Join(" ", ask));
        }

        static HashSet<int> FillSets(HashSet<int> set, int ask)
        {
            for (int i = 0; i < ask; i++)
            {
                set.Add(int.Parse(Console.ReadLine()));
            }
            return set;
        }
    }
}
