
namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;


        public int Year { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            var isture=FuelQuantity - distance * FuelConsumption > 0;
            if (isture)
            {
                this.FuelQuantity = distance * this.FuelConsumption;
            }
            else
            {
                System.Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
           return ($"Make: { this.Make}\nModel: { this.Model}\nYear: { this.Year}\nFuel: { this.FuelQuantity:F2}L").ToString(); 
        }

    }
}
