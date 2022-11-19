using System;
using System.Collections.Generic;
using System.Linq;

namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> ask = new Stack<int>();
            var numbers = Console.ReadLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                var curchar = char.Parse(numbers[i].ToString());
                if (curchar == '(')
                {
                    ask.Push(i);
                }
                else if (curchar == ')')
                {
                    var start = ask.Pop();
                    var result = numbers.Substring(start, i - start + 1);
                    Console.WriteLine(result);
                }
            }


        }
    }
}
