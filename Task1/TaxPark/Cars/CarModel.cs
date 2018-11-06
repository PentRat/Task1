using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Task1.TaxPark.Cars
{
    [DataContract]
    public class CarModel
    {
        [DataMember]
        public string Name { get; private set; }

        [DataMember]
        public decimal Price { get; private set; }

        [DataMember]
        public double FuelConsumption { get; private set; }

        [DataMember]
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
