using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cars_Preview.Model
{
    internal class ParrentClass : INotifyPropertyChanged
    {
        public string carsPath = "../Data.json";
        public string brandsPath = "../Brands.json";

        public event PropertyChangedEventHandler? PropertyChanged;

        public List<Car> loadCars()
        {
            try
            {
                string json = File.ReadAllText(carsPath);
                return JsonConvert.DeserializeObject<List<Car>>(json);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found");
                return null;
            }
        }

        public List<Brand> loadBrands()
        {
            try
            {
                string json = File.ReadAllText(brandsPath);
                return JsonConvert.DeserializeObject<List<Brand>>(json);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found");
                return null;
            }
        }
    }
}
