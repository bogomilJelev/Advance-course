using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }
        public Car(string make,string model,int hoursepower,string reg)
        {
            Make = make;
            Model = model;
            HorsePower = hoursepower;
            RegistrationNumber = reg;
            
        }
        public override string ToString()
        {
            StringBuilder ask = new StringBuilder();
            ask.AppendLine($"Make: {Make}");
            ask.AppendLine($"Model: {Model}");
            ask.AppendLine($"HorsePower: {HorsePower}");
            ask.AppendLine($"RegistrationNumber: {RegistrationNumber}");
            return ask.ToString();
          
        }
    }
}
