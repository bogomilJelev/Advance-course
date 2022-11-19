using System;
using System.Collections.Generic;
using System.Linq;

namespace sealing
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingr = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> fressnes = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            SortedDictionary<string, int> Dish = new SortedDictionary<string, int>();
            Dish.Add("Green salad", 0);
            Dish.Add("Lobster", 0);
            Dish.Add("Dipping sauce", 0);
            Dish.Add("Chocolate cake", 0);

            while (ingr.Any() && fressnes.Any())
            {
                if (ingr.Peek() == 0)
                {
                    ingr.Dequeue();
                    continue;
                }
                int ing = ingr.Peek();
                int fres = fressnes.Peek();
                if (ing * fres == 150)
                {
                    Dish["Dipping sauce"]++;
                    ingr.Dequeue();
                    fressnes.Pop();
                }
                else if (ing * fres == 250)
                {
                    Dish["Green salad"]++;
                    ingr.Dequeue();
                    fressnes.Pop();
                }
                else if (ing * fres == 300)
                {
                    Dish["Chocolate cake"]++;
                    ingr.Dequeue();
                    fressnes.Pop();
                }
                else if (ing * fres == 400)
                {
                    Dish["Lobster"]++;
                    ingr.Dequeue();
                    fressnes.Pop();
                }
                else
                {
                    fressnes.Pop();
                    ingr.Enqueue(ingr.Dequeue() + 5);
                }

            }
            if (Dish["Dipping sauce"] >= 1 && Dish["Green salad"] >= 1 &&
                    Dish["Chocolate cake"] >= 1 && Dish["Lobster"] >= 1)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");

                foreach (var item in Dish)
                {
                    Console.WriteLine($" # {item.Key} --> {item.Value}");
                }

            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
                if (ingr.Count > 0)
                {
                    long ingredientsSum = ingr.Sum();
                    Console.WriteLine($"Ingredients left: {ingredientsSum}");
                }
                foreach (var item in Dish)
                {
                    if (item.Value > 0)
                    {
                        Console.WriteLine($" # {item.Key} --> {item.Value}");
                    }

                }
            }
        }
    }
}