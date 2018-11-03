using System;
using Task1.TaxPark.CarsManagment;
using Task1.TaxPark.DataManagment;

namespace Task1.TaxPark
{
    public class TaxiPark
    {
        public string Name { get; private set; }

        public AutoPark Autopark { get; set; }

        public CarShop CarShop { get;  set; }

        private FileBrowser FileBrowser { get; set; }
        
        public TaxiPark(string name)
        {
            Name = name;
            FileBrowser = new FileBrowser();
            Autopark = FileBrowser.LoadAutopark(name);
            CarShop = FileBrowser.LoadCarShop(name);
        }

        public void SaveCarshop()
        {
            FileBrowser.SaveCarshop(CarShop, Name);
        }
        public void SaveAutopark()
        {
            FileBrowser.SaveCarshop(Autopark, Name);
        }
        
    }
}
