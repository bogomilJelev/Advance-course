using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {

            //string make = Console.ReadLine();
            //string model =Console.ReadLine();
            //int year = int.Parse(Console.ReadLine());
            //double fuelQuantity = double.Parse(Console.ReadLine());
            //double fuelConsumption = double.Parse(Console.ReadLine());
            //Car first = new Car();
            //Car second = new Car(make, model, year);
            //Car thirt = new Car(make, model, year, fuelQuantity, fuelConsumption);
             Tire[] tiress = new Tire[]
            {
                new Tire(2000,2.5),
                new Tire(2000,2.3),
                new Tire(2000,0.5),
                new Tire(2000,2.4),
            };

            
            var engine = new Engine(560, 6300);

            var car = new Car("Lambo", "Urus", 2010, 250, 9, engine, tiress);
           
        
        }

    }

    
}
