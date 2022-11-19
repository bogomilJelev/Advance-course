using System;
using System.Collections.Generic;

namespace Reverse_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> ask = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                ask.Push(input[i]);
            }
            Console.WriteLine(string.Join("", ask));
        }

    }
}
