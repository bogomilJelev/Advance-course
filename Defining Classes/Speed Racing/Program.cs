using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            List<Car> ask = new List<Car>();
            for (int i = 0; i < x; i++)
            {
                string[] carsinfo = Console.ReadLine().Split();
                string namecar = carsinfo[0];
                double fulelit = double.Parse(carsinfo[1]);
                double fuelperkilo = double.Parse(carsinfo[2]);
                Car car = new Car(namecar, fulelit, fuelperkilo);
                ask.Add(car);

                
            }
            string[] com2 = Console.ReadLine().Split();
            while (com2[0] != "End")
            {
                string model = com2[1];
                double amounKm = double.Parse(com2[2]);
                Car carfirdrive = ask.Where(x => x.Model == model).ToList().First();
                carfirdrive.CanDrive(model, amounKm);

                com2 = Console.ReadLine().Split();
            }
            foreach (var item in ask)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:F2} {item.Travelleddistance}");
            }
            {

            }
            
        }
    }
}
