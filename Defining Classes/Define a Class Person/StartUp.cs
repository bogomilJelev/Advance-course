using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person Pesho = new Person();
            Pesho.Age = 20;
            Pesho.Name = "Pesho";
            Console.WriteLine($"{Pesho.Name} => {Pesho.Age}");
        }
    }
}
