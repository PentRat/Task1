using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Task1.TaxPark.Cars
{
    [DataContract]
    public class CarrierModel : CarModel
    {
        [DataMember]
        public double LuggageCapacity { get; private set; }

        public CarrierModel(string name, 
            decimal price, 
            double fuelConsumption, 
            double maxSpeed,
            double luggageCapacity) : 
            base(name, 
                price,
                fuelConsumption, 
                maxSpeed)
        {
            LuggageCapacity = luggageCapacity;
        }
    }
}
