using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Task1.TaxPark.Cars;


namespace Task1.TaxPark.CarsManagment
{
    [DataContract]
    public class AutoPark
    {
        [DataMember]
        public IList<Taxi> TaxiCars { get; set; }

        public AutoPark()
        {
            TaxiCars = new List<Taxi>();
            
        }

        public decimal CalculateAutoparkPrice()
        {
            decimal cost = 0;
            foreach (var car in TaxiCars)
            {
                cost += car.CarModel.Price;
            }
            return cost;
        }

        void AddTaxi(int index, string licensePlateNumber)
        {
            Taxi taxi = CarShop.GetTaxiCar(index, licensePlateNumber);
            TaxiCars.Add(taxi);
        }

        public IEnumerable<Taxi> SortByFuelConsumption()
            => from car in TaxiCars
               orderby car.CarModel.FuelConsumption
               select car;

        public IEnumerable<Taxi> SearchBySpeedInterval(double minSpeed, double maxSpeed)
            => from car in TaxiCars
               where car.CarModel.MaxSpeed > minSpeed && car.CarModel.MaxSpeed < maxSpeed
               select car;
    }
}
