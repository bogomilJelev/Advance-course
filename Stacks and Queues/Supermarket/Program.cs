using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var ask = new Queue<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Paid")
                {
                    for (int i = 1; i <= ask.Count;)
                    {
                        Console.WriteLine(ask.Dequeue());
                    }
                    continue;
                }
                else if (input == "End")
                {
                    break;
                }
                ask.Enqueue(input);

            }
            Console.WriteLine($"{ask.Count} people remaining.");
        }
    }
}
