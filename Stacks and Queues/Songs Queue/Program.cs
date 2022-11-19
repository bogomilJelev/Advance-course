using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] music = Console.ReadLine().Split(", ").ToArray();
            Queue<string> stack = new Queue<string>();
            for (int i = 0; i < music.Length; i++)
            {
                stack.Enqueue(music[i]);
            }
            while (stack.Any())
            {
                string[] comand = Console.ReadLine().Split().ToArray();
                if (comand[0] == "Play")
                {
                    stack.Dequeue();
                }
                else if (comand[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", stack));
                }
                else if (comand[0] == "Add")
                {

                    string cur = string.Empty;
                    for (int i = 1; i < comand.Length; i++)
                    {
                        if (comand.Length - 1 == i)
                        {
                            cur += comand[i];
                        }
                        else
                        {
                            cur += (comand[i] + " ");

                        }
                    }
                    if (stack.Contains(cur))
                    {
                        Console.WriteLine($"{cur} is already contained!");
                    }
                    else
                    {
                        stack.Enqueue(cur);
                    }
                }


            }
            Console.WriteLine("No more songs!");
        }
    }
}
