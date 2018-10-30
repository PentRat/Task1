using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.TaxPark.Cars
{
    public class TaxiCar
    
    {
        public CarModel CarModel { get; private set; }

        public string LicensePlateNumber { get; private set; }

        public TaxiCar(CarModel carModel, string licensePlateNumber)
        {
            CarModel = carModel;
            LicensePlateNumber = licensePlateNumber;
        }

    }
}

