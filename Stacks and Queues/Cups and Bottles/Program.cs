using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cupsinput = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> bottleinput = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int wastewater = 0;
            int sumwast = 0;
            while (cupsinput.Any() && bottleinput.Any())
            {
                if (cupsinput.Peek() <= bottleinput.Peek())
                {
                    wastewater += bottleinput.Pop() - cupsinput.Dequeue();

                }
                else
                {
                    int curcup = cupsinput.Dequeue();
                    int curbottle = bottleinput.Pop();
                    while (curcup >= 0)
                    {
                        curcup -= curbottle;
                        if (curcup <= 0)
                        {
                            sumwast += Math.Abs(curcup);
                            break;
                        }
                        curbottle = bottleinput.Pop();
                    }

                }
            }
            if (cupsinput.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cupsinput)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottleinput)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastewater + sumwast}");
        }
    }
}
