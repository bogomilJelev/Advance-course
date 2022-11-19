using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var buletprice = int.Parse(Console.ReadLine());
            var magazinebarel = int.Parse(Console.ReadLine());
            string[] bus = Console.ReadLine().Split().ToArray();
            var bulets = new Stack<int>();
            for (int i = 0; i < bus.Length; i++)
            {
                int ask = int.Parse(bus[i]);
                bulets.Push(ask);
            }
            string[] bus2 = Console.ReadLine().Split().ToArray();
            var locks = new Queue<int>();
            for (int i = 0; i < bus2.Length; i++)
            {
                int ask = int.Parse(bus2[i]);
                locks.Enqueue(ask);
            }
            var price = int.Parse(Console.ReadLine());
            var buletcount = 0;
            var barrelcount = 0;
            while (bulets.Any() && locks.Any())
            {
                if (locks.Peek() >= bulets.Peek())
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                    bulets.Pop();
                }
                else
                {
                    Console.WriteLine("Ping!");
                    bulets.Pop();
                }
                barrelcount++;

                if (barrelcount == magazinebarel && bulets.Any())
                {
                    Console.WriteLine("Reloading!");
                    barrelcount = 0;
                }
                buletcount++;
            }
            if (bulets.Count >= 0 && locks.Count == 0)
            {
                var earn = price - (buletcount * buletprice);
                Console.WriteLine($"{bulets.Count} bullets left. Earned ${earn}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }

    }
}
