using System;
using System.Runtime.Serialization;

namespace Task1.TaxPark.Cars
{
    [DataContract]
    public class Taxi

    {
        [DataMember]
        public CarModel CarModel { get; private set; }

        [DataMember]
        public string LicensePlateNumber { get; private set; }

        public Taxi(CarModel carModel, string licensePlateNumber)
        {
            CarModel = carModel;
            LicensePlateNumber = licensePlateNumber;
        }

    }
}