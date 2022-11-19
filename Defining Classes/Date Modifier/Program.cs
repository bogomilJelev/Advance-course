using System;

namespace date
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstdate = Console.ReadLine();
            string seconddate = Console.ReadLine();
            int days = DateModifier.GetDIffDate(firstdate, seconddate);
           
            Console.WriteLine(days);
        }
    }
}
