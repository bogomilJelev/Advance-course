using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] num2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>();
            int min = int.MaxValue;
            for (int i = 0; i < num[0]; i++)
            {
                stack.Push(num2[i]);
            }
            for (int i = 0; i < num[1]; i++)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            if (stack.Contains(num[2]))
            {
                Console.WriteLine("true");
            }
            else if (!stack.Contains(num[2]))
            {
                if (!stack.Any())
                {
                    Console.WriteLine("0");
                }
                else
                {
                    foreach (var item in stack)
                    {
                        if (min > item)
                        {
                            min = item;
                        }
                    }
                    Console.WriteLine(min);

                }
            }
        }
    }
}
