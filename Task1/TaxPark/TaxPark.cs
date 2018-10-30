using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.TaxPark.CarsEngagment;
using Task1.TaxPark.DataEngagment;

namespace Task1.TaxPark
{
    public class TaxPark
    {
        public string Name { get; private set; }

        public AutoPark Autopark { get; set; }

        public CarShop CarShop { get;  set; }

        private FileBrowser FileBrowser { get; set; }
        
        public TaxPark(string name)
        {
            Name = name;
            Autopark = new AutoPark();
            CarShop = new CarShop();
            FileBrowser = new FileBrowser();
        }
    }
}
