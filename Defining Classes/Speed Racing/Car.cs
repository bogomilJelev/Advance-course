using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double Travelleddistance { get; set; }

        public Car(string model, double fuelam,double fuelconsump)
        {

            Model = model;
            FuelAmount = fuelam;
            FuelConsumptionPerKilometer = fuelconsump;
            Travelleddistance = 0;
        }


        public void CanDrive(string model,double amountlit)
        {
            if (FuelAmount >= (FuelConsumptionPerKilometer * amountlit))
            {
                FuelAmount -= FuelConsumptionPerKilometer * amountlit;
                Travelleddistance += amountlit;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
