using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Task1.TaxPark.CarsManagment;


namespace Task1.TaxPark.DataManagment
{
    class FileBrowser
    {
        private const string DataPath = ("d:\\TaxPark\\");
     


        public void SaveCarshop(CarShop carShop, string taxParkName)
        {
            string CarShopData = JsonConvert.SerializeObject(carShop);
            string FileToSave = DataPath + taxParkName + ".CarShop.json";
            Directory.CreateDirectory(DataPath);
            File.WriteAllText( FileToSave , CarShopData, Encoding.UTF32);
        }

        public void SaveCarshop(AutoPark autoPark, string taxParkName)
        {
            string AutoParkData = JsonConvert.SerializeObject(autoPark);
            string FileToSave = DataPath + taxParkName + ".AutoPark.json";
            Directory.CreateDirectory(DataPath) ;
            File.WriteAllText(FileToSave, AutoParkData, Encoding.UTF32);

        }

        public CarShop LoadCarShop(string taxParkName)
        {
            string FileToLoad = DataPath + taxParkName + ".CarShop.json";
            CarShop carShop;
            return carShop = File.Exists(FileToLoad) ? JsonConvert.DeserializeObject<CarShop>(File.ReadAllText(FileToLoad)) : new CarShop();
        }

        public AutoPark LoadAutopark(string taxParkName)
        {
            string FileToLoad = DataPath + taxParkName + ".AutoPark.json";
            AutoPark autoPark;
            return autoPark = File.Exists(FileToLoad) ? JsonConvert.DeserializeObject<AutoPark>(File.ReadAllText(FileToLoad)) : new AutoPark();
        }




        //string FileName = TaxPark.Name

        //4 methods - read/write
    }
}
