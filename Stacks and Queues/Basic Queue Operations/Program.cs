using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ask = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] ask2 = Console.ReadLine().Split().ToArray();
            int min = int.MaxValue;
            var que = new Queue<int>();

            for (int i = 0; i < ask[0]; i++)
            {
                que.Enqueue(int.Parse(ask2[i]));
            }
            for (int i = 0; i < ask[1]; i++)
            {
                if (que.Count > 0)
                {
                    que.Dequeue();
                }
            }
            if (que.Contains(ask[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(que.Count > 0 ? que.Min() : 0);

            }

        }
    }
}
