using Cars_Preview.Model;
using Cars_Preview.View;
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

namespace Cars_Preview.ViewModel
{
    internal class Vm_EditCar : ParrentClass
    {
        public List<Car> CarsCollection { get; set; }
        public Car SelectedCar { get; set; }
        public List<Brand> BrandCollection { get; set; }
        public Vm_EditCar()
        {
            CarsCollection = loadCars();
            BrandCollection = loadBrands();
            if(SelectedCar?.CarName == "")
            {
                MessageBox.Show("CarName not found");
            }
        }
        
        public void safeCars()
        {
            if (SelectedCar.CarName != "")
            {
                CarsCollection[CarsCollection.FindIndex(car => car.Id == SelectedCar.Id)] = SelectedCar;
            }
            else
            {

                MessageBox.Show("CarName not found");
            }
            
            File.WriteAllText(carsPath, JsonConvert.SerializeObject(CarsCollection));
        }



    }
}
