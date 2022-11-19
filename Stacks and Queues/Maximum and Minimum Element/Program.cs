using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var ask = new Stack<string>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] comand = Console.ReadLine().Split().ToArray();
                string com = comand[0];
                if (com == "1")
                {
                    string comdig = comand[1];
                    ask.Push(comdig);
                }
                else if (com == "2")
                {
                    if (ask.Count > 0)
                    {
                        ask.Pop();
                    }
                }
                else if (com == "3")
                {
                    if (ask.Count > 0)
                    {
                        Console.WriteLine(ask.Max());
                    }
                }
                else if (com == "4")
                {
                    if (ask.Count > 0)
                    {
                        Console.WriteLine(ask.Min());
                    }
                }
            }
            if (ask.Count > 0)
            {
                Console.WriteLine(string.Join(", ", ask));
            }
        }
    }
}
