using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var ask = new Queue<string>();
            int count = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "green")
                {
                    for (int i = 0; i < num && ask.Any(); i++)
                    {
                        count++;
                        Console.WriteLine($"{ask.Dequeue()} passed!");
                    }
                    continue;
                }
                else if (input == "end")
                {
                    break;
                }
                ask.Enqueue(input);
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}