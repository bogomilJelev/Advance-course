using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (dic.ContainsKey(text[i]))
                {
                    dic[text[i]]++;
                }
                else
                {
                    dic.Add(text[i], 1);
                }
            }
            foreach (var item in dic.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }


        }
    }
}
