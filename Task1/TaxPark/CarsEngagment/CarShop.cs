using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.TaxPark.Cars;

namespace Task1.TaxPark.CarsEngagment
{
    public class CarShop : ICollection<CarModel>
    {
        private ICollection<CarModel> carModels;

        public int Count => carModels.Count;

        public bool IsReadOnly => carModels.IsReadOnly;

        public void Add(CarModel item) => carModels.Add(item);
       
        public void Clear() => carModels.Clear();

        public bool Contains(CarModel item) =>
            carModels.Contains(item);

        public void CopyTo(CarModel[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<CarModel> GetEnumerator()=> carModels.GetEnumerator();

        public bool Remove(CarModel item) => carModels.Remove(item);
  
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public CarShop()
        {
            carModels =  new List<CarModel>();
        }
    }
}
