using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Task1.TaxPark.Cars;

namespace Task1.TaxPark.CarsManagment
{
    [DataContract]
    public class CarShop
    {
        [DataMember]
        public IList<CarModel> CarModels { get; set; }

        public CarShop()
        {
            CarModels = new List<CarModel>();
        }

        public TaxiCar GetTaxiCar(int carModelIndex, string licensePlateNumber)
        {
            CarModel carModel = CarModels[carModelIndex];
            return new TaxiCar(carModel, licensePlateNumber);
        }
    }
}
