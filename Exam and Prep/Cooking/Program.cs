using System;
using System.Collections.Generic;
using System.Linq;

namespace sealing
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquid = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> ingrid = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int bread = 0;
            int cake = 0;
            int pasty = 0;
            int fruidpie = 0;
            while (liquid.Any() && ingrid.Any())
            {
                if (liquid.Peek() + ingrid.Peek() == 25)
                {
                    bread++;
                    liquid.Dequeue();
                    ingrid.Pop();
                }
                else if (liquid.Peek() + ingrid.Peek() == 50)
                {
                    liquid.Dequeue();
                    ingrid.Pop();
                    cake++;
                }
                else if (liquid.Peek() + ingrid.Peek() == 75)
                {
                    liquid.Dequeue();
                    ingrid.Pop();
                    pasty++;
                }
                else if (liquid.Peek() + ingrid.Peek() == 100)
                {
                    liquid.Dequeue();
                    ingrid.Pop();
                    fruidpie++;
                }
                else
                {
                    liquid.Dequeue();
                    ingrid.Push(ingrid.Pop() + 3);
                }
            }
            if (bread > 0 && cake > 0 && pasty > 0 && fruidpie > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
            if (liquid.Any())
            {
                Console.WriteLine("Liquids left: " + string.Join(", ", liquid));
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }
            if (ingrid.Any())
            {
                Console.WriteLine("Ingredients left: " + string.Join(", ", ingrid));
            }
            else
            {
                Console.WriteLine("Ingredients left: none");
            }
            Console.WriteLine($"Bread: {bread}");
            Console.WriteLine($"Cake: {cake}");
            Console.WriteLine($"Fruit Pie: {fruidpie}");
            Console.WriteLine($"Pastry: {pasty}");

        }


    }
}
