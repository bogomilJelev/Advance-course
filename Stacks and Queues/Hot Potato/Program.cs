using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split().ToArray();
            var num = int.Parse(Console.ReadLine());
            var ask = new Queue<string>(names);
            while (ask.Count != 1)
            {
                for (int i = 1; i < num; i++)
                {
                    ask.Enqueue(ask.Dequeue());
                }
                Console.WriteLine($"Removed {ask.Dequeue()}");
            }
            Console.WriteLine($"Last is {ask.Dequeue()}");



        }
    }
}
