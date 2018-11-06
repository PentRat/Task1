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
    public class TaxiCar
    
    {
        [DataMember]
        public CarModel CarModel { get; private set; }

        [DataMember]
        public string LicensePlateNumber { get; private set; }
       
        public TaxiCar(CarModel carModel, string licensePlateNumber)
        {
            CarModel = carModel;
            LicensePlateNumber = licensePlateNumber;
        }

    }
}

