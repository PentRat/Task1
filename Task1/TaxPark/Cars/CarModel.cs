using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.TaxPark.Cars
{
    public class CarModel
    {
        public string Name { get; private set; }

        public decimal Price { get; private set; }

        public double FuelConsumption { get; private set; }

        public double MaxSpeed { get; private set; }

        public CarModel(string name, decimal price, double fuelConsumption, double maxSpeed)
        {
            Name = name;
            Price = price;
            FuelConsumption = fuelConsumption;
            MaxSpeed = maxSpeed;
        }
    }
}
