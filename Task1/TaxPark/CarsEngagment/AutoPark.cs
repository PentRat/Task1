using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.TaxPark.Cars;

namespace Task1.TaxPark.CarsEngagment
{
    public class AutoPark : ICollection<TaxiCar>
    {
        private ICollection<TaxiCar> taxiCars;


        public int Count => taxiCars.Count;

        public bool IsReadOnly => taxiCars.IsReadOnly;

        public void Add(TaxiCar item) => taxiCars.Add(item);

        public void Clear() => taxiCars.Clear();

        public bool Contains(TaxiCar item) => taxiCars.Contains(item);

        public void CopyTo(TaxiCar[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<TaxiCar> GetEnumerator() => taxiCars.GetEnumerator();

        public bool Remove(TaxiCar item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public decimal CalculateAutoparkPrice()
        {
            decimal cost = 0;
            foreach (var car in taxiCars)
                {
                cost += car.CarModel.Price;
                }
            return cost;
        }
        
        public IEnumerable<TaxiCar> SortByFuelConsumption()
            => from car in this
               orderby car.CarModel.FuelConsumption
               select car;

        public IEnumerable<TaxiCar> SearchBySpeedInterval(double minSpeed, double maxSpeed)
            => from car in this
               where car.CarModel.MaxSpeed > minSpeed && car.CarModel.MaxSpeed < maxSpeed
               select car;

        public AutoPark()
        {
            taxiCars = new List<TaxiCar>();
        }

    }
}
