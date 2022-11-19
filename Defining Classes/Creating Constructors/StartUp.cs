using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            string name = "shashp";
            int age = 12;
            Person sshasho = new Person(name, age);
            Console.WriteLine($"{sshasho.Name} => {sshasho.Age}");
        }
    }
}
