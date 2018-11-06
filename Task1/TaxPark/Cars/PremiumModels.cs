using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Task1.TaxPark.Cars
{   [DataContract]
    public class PremiumModel : CarModel
    {
        [DataMember]
        public string AdditionalEquipment { get; private set; }

        public PremiumModel(string name, 
            decimal price, 
            double fuelConsumption, 
            double maxSpeed, 
            string additionalEquipement) :
            base(name,
                price,
                fuelConsumption,
                maxSpeed)
        {
            AdditionalEquipment = additionalEquipement;
        }
    }
}
