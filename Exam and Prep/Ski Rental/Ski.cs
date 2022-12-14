using System;
using System.Collections.Generic;
using System.Text;

namespace SkiRental
{
    public class Ski
    {
        //private string manufacturer;
        //private string model;
        //private int year;

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Ski(string manufacturer,string model,int year)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Manufacturer} - {Model} - {Year}";
        }

    }
}
