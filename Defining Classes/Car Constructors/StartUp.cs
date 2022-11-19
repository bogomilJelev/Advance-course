using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car();
            string make = Console.ReadLine();
            string model =Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());
            Car first = new Car();
            Car second = new Car(make, model, year);
            Car thirt = new Car(make, model, year, fuelQuantity, fuelConsumption);

        }
    }
}
