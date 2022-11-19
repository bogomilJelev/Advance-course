using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> ask = new Stack<int>();
            List<string> examps = Console.ReadLine().Split().ToList();
            for (int i = 0; i < examps.Count; i++)
            {
                if (examps[i] == "-")
                {
                    ask.Push(int.Parse(ask.Pop().ToString()) - int.Parse(examps[i + 1]));
                    i++;
                }
                else if (examps[i] == "+")
                {

                    ask.Push(int.Parse(ask.Pop().ToString()) + int.Parse(examps[i + 1]));
                    i++;
                }
                else
                {
                    ask.Push(int.Parse(examps[i]));
                }
            }
            Console.WriteLine(ask.Pop());

        }
    }
}
