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
            int quantity = int.Parse(Console.ReadLine());
            var order = new Queue<int>();
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            foreach (var item in orders)
            {
                order.Enqueue(item);
            }
            Console.WriteLine(order.Max());
            for (int i = 0; i < order.Count && quantity >= order.Peek();)
            {

                quantity -= order.Dequeue();

            }
            if (order.Any())
            {
                Console.Write("Orders left: ");
                Console.Write(string.Join(" ", order));
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
