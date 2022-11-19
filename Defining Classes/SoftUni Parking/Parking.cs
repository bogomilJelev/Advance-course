using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    class Parking
    {
        private List<Car> cars;
        private int capacity;
        public int Count => cars.Count;
        public Parking(int capacity )
        {

            cars = new List<Car>(capacity);
        }
        public string AddCar(Car car)
        {
            if (cars.Contains(car))
            {
                return "Car with that registration number, already exists!";
            }
            else if (cars.Count < capacity)
            {
                return "Parking is full!";
            }
            else
            {
                cars.Add(car);
                return $"Successfully added new car { car.Make} { car.RegistrationNumber}";
            }
            
        }
        public string RemoveCar(string regi)
        {
            Car car = cars.OrderByDescending(x => x.RegistrationNumber == regi).FirstOrDefault();
            if (car == null)
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                cars.Remove(car);
                return $"Successfully removed {car.RegistrationNumber}";
            }
        }
        public Car GetCar(string regi)
        {
            Car car = cars.OrderByDescending(x => x.RegistrationNumber == regi).First();
            return car;
        }
        public void RemoveSetOfRegistrationNumber(List<string>RegistrationNumbers)
        {
            foreach (var item in cars)
            {
                foreach (var item2 in RegistrationNumbers)
                {
                    if (item.RegistrationNumber == item2)
                    {
                        cars.Remove(item);
                    }
                }
            }
        }
    }
}
