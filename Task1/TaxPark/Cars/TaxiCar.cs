using System;
using System.Runtime.Serialization;

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

