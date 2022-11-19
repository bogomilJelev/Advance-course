using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> ask = new Stack<int>();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                ask.Push(input[i]);
            }
            while (true)
            {
                string[] input2 = Console.ReadLine().Split();
                string com = input2[0].ToLower();
                if (com == "end")
                {
                    break;
                }
                else if (com == "add")
                {
                    int num1 = int.Parse(input2[1]);
                    int num2 = int.Parse(input2[2]);
                    ask.Push(num1);
                    ask.Push(num2);

                }
                else if (com == "remove")
                {
                    int num1 = int.Parse(input2[1]);
                    if (ask.Count > num1)
                    {
                        for (int i = 0; i < num1; i++)
                        {
                            ask.Pop();
                        }
                    }
                }
            }
            int count = ask.Count;
            for (int i = 0; i < count; i++)
            {
                sum += ask.Pop();
            }
            Console.WriteLine($"Sum: {sum}");

        }

    }
}
