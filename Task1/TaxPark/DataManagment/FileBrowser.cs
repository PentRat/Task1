using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Task1.TaxPark.CarsManagment;
using Task1.TaxPark;


namespace Task1.TaxPark.DataManagment
{
    class FileBrowser
    {
        private const string CarShopDataPath = ("path" );
        private const string AutoparkDataPath = ("Another One data path");

        
        DataContractJsonSerializer CarShopSave = new DataContractJsonSerializer(typeof(CarShop));
        DataContractJsonSerializer AutoparkSave = new DataContractJsonSerializer(typeof(AutoPark));

       //string FileName = TaxPark.Name

        //4 methods - read/write
    }
}
