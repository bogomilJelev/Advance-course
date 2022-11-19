using System;
using System.Collections.Generic;
using System.Linq;

namespace sass
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstbox = new Queue<int>();
            Stack<int> secondbox = new Stack<int>();
            int[] fi = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sec = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < fi.Length; i++)
            {
                firstbox.Enqueue(fi[i]);
            }
            for (int z = 0; z < sec.Length; z++)
            {
                secondbox.Push(sec[z]);
            }
            List<int> ask = new List<int>();
            bool firstboxx = false;
            bool secondboxx = false;
            while (firstbox.Any() && secondbox.Any())
            {
                int first = firstbox.Peek();
                int second = secondbox.Peek();
                int sum1 = first + second;
                if (sum1 % 2 == 0)
                {
                    ask.Add(firstbox.Dequeue() + secondbox.Pop());
                }
                else
                {
                    firstbox.Enqueue(secondbox.Pop());
                }
                if (!(firstbox.Any()))
                {
                    firstboxx = true;
                    Console.WriteLine("First lootbox is empty");
                    break;
                }
                else if (!(secondbox.Any()))
                {

                    secondboxx = true;
                    Console.WriteLine("Second lootbox is empty");
                    break;
                }
            }
            int sum = 0;
            foreach (var item in ask)
            {
                sum += item;
            }
            if (sum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sum}");
            }
        }
    }
}
