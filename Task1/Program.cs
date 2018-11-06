using System;
using Task1.TaxPark;
using Task1.TaxPark.CarsManagment;
using Task1.TaxPark.DataManagment;

namespace Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            TaxiPark taxiPark = new TaxiPark("Flower");

            //taxiPark.CarShop.Test();
            //taxiPark.Autopark.Test();

            taxiPark.CarShop.AddNewModel("Fiat", 50000, 24, 200);
            taxiPark.CarShop.AddCarrierModel("AudiXL", 1000000, 42, 420, 42);
            taxiPark.CarShop.AddPremiumModel("Bentley", 1000000, 42, 420, "PassangerIsolation");
            taxiPark.SaveCarshop();
            taxiPark.SaveAutopark();
          
            
            decimal x = taxiPark.Autopark.CalculateAutoparkPrice();
            Console.WriteLine(x);
            Console.ReadKey();



        }


    }
}
