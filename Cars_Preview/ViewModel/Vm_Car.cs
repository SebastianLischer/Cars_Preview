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
        }

        public List<Car> CarsCollection { get; set; }
        public List<string> brands { get; set; }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            var handler = PropertyChanged;
            if (handler != null && name != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        string path = "../Data.json";
        public void loadCars()
        {
            //_CarsCollection.Add(new Car() { Name = "Audi", Description = "moderner Sportwagen", Price = 444444 });
            //_CarsCollection.Add(new Car() { Name = "Porsche", Description = "moderner Sportwagen", Price = 444444 });
            //_CarsCollection.Add(new Car() { Name = "Bugatti", Description = "moderner Sportwagen", Price = 444444 });
            //_CarsCollection.Add(new Car() { Name = "VW", Description = "moderner Sportwagen", Price = 444444 });

            string json = File.ReadAllText(path);
            CarsCollection = JsonConvert.DeserializeObject<List<Car>>(json);
        }

        public void safeCars()
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(CarsCollection));
        }

        public List<string> getBrand()
        {
            
            brands = new List<string>();
            foreach (var car in CarsCollection)
            {
                brands.Add(car.Brand);
            }
            return brands;
        }

    }


}

