using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> inputhat = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> inputscarf = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int maxprice = 0;
            List<int> sets = new List<int>();
            while (inputhat.Any() && inputscarf.Any())
            {
                if (inputhat.Peek() == inputscarf.Peek())
                {
                    inputscarf.Dequeue();
                    inputhat.Push(inputhat.Pop() + 1);
                }
                else if (inputhat.Peek() > inputscarf.Peek())
                {

                    int hat = inputhat.Pop();
                    int scarf = inputscarf.Dequeue();
                    int sum = hat + scarf;
                    sets.Add(sum);

                }
                else if (inputhat.Peek() < inputscarf.Peek())
                {
                    inputhat.Pop();
                }
            }
            foreach (var item in sets)
            {
                if (item >= maxprice)
                {
                    maxprice = item;
                }
            }
            Console.WriteLine($"The most expensive set is: {maxprice}");
            Console.WriteLine(string.Join(" ", sets));
        }

    }
}
