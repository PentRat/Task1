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
        static public IList<CarModel> CarModels { get; set; }

        [DataMember]
        static public IList<CarrierModel> CarrierModels { get; set; }

        [DataMember]
        static public IList<PremiumModel> PremiumModels { get; set; }

        public CarShop()
        {
            CarModels = new List<CarModel>();
            CarrierModels = new List<CarrierModel>();
            PremiumModels = new List<PremiumModel>();
        }

        public void AddNewModel(string modelName, 
            decimal price,
            double fuelConsumption,
            double maxSpeed)
        {
            CarModel NewModel = new CarModel(modelName, price, fuelConsumption, maxSpeed);
            CarModels.Add(NewModel);
        }
        public void AddCarrierModel(string modelName, 
            decimal price, 
            double fuelConsumption, 
            double maxSpeed, 
            double luggageCapacity)
        {
            CarrierModel NewModel = new CarrierModel(modelName, price, fuelConsumption, maxSpeed, luggageCapacity);
            CarrierModels.Add(NewModel);
        }
        public void AddPremiumModel(string modelName, decimal price, double fuelConsumption, double maxSpeed, string additionalEquipement)
        {
            PremiumModel NewModel = new PremiumModel(modelName, price, fuelConsumption, maxSpeed, additionalEquipement);
            PremiumModels.Add(NewModel);
        }
        


        delegate Taxi GetNewCar(int index, string licenseNumber); 

        static public Taxi GetTaxiCar(int carModelIndex, string licensePlateNumber)
        {
            CarModel carModel = CarModels[carModelIndex];
            return new Taxi(carModel, licensePlateNumber);
        }

        public void Test()
        {
            string modelName = "AUDI";
            decimal price = 100000;
            double fuelConsumption = 42;
            double maxSpeed = 400;

            CarModel carModel = new CarModel(modelName, price, fuelConsumption, maxSpeed);
            CarModels.Add(carModel);
        }
    

        GetNewCar getNewCar = GetTaxiCar;

        
    }
}
