using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.RightsManagement;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Cars_Preview.Model;
using Cars_Preview.View;
using Newtonsoft.Json;

namespace Cars_Preview.ViewModel
{
    class Vm_Car : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;


        public Vm_Car()
        {
            this.loadCars();
            this.loadBrands();
        }

        public List<Car> CarsCollection { get; set; }
        public List<Brand> BrandCollection { get; set; }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            var handler = PropertyChanged;
            if (handler != null && name != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        string carsPath = "../Data.json";
        public void loadCars()
        {
            string json = File.ReadAllText(carsPath);
            CarsCollection = JsonConvert.DeserializeObject<List<Car>>(json);
        }
        string brandsPath = "../Brands.json";
        public void loadBrands()
        {

            string json = File.ReadAllText(brandsPath);
            BrandCollection = JsonConvert.DeserializeObject<List<Brand>>(json);
        }

        public void safeCars()
        {
            File.WriteAllText(carsPath, JsonConvert.SerializeObject(CarsCollection));
        }

        //public List<string> getBrand()
        //{
            
        //    Brand = new List<string>();
        //    foreach (var car in CarsCollection)
        //    {
        //        Brand.Add(car.Brand);
        //    }
        //    return Brand;
        //}

    }


}

