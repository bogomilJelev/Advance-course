using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
   public class Car
    {
        string make;
        string model;
        int year;
        double fuelQuantity;
        double fuelConsumption;


        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public Car() 
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }
        
        public Car(string make,string model,int year)
            :this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make,string model,int year,double fuelQuantity,double fuelConsumption)
            : this(make,model,year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }



        public void Drive(double distance)
        {
            if (fuelQuantity-(distance*fuelConsumption)<0)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                fuelQuantity -= distance * fuelConsumption;
            }
        }
        public string WhoAmI()
        {
            return $"Make: { this.Make}\nModel: { this.Model}\nYear: { this.Year}\nFuel: { this.FuelQuantity:F2} L";
        }
            
    }
}
