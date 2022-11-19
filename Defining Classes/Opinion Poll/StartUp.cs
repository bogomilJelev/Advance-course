using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family famili = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] ask = Console.ReadLine().Split();
                string name = ask[0];
                int age = int.Parse(ask[1]);

                Person person = new Person(name, age);
                famili.AddMember(person);
            }
            famili.GetOldestMember();

        }
    }
}
