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

namespace Cars_Preview.ViewModel
{
    internal class Vm_EditCar : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public Vm_EditCar()
        {
            loadCars();
        }

        public List<Car> CarsCollection { get; set; }
        public Car SelectedCar { get; set; }

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
        public void safeCars()
        {
            Car carToEdit = CarsCollection.FirstOrDefault(car => car.Id == SelectedCar.Id);
            if (carToEdit != null)
            {
                carToEdit.BrandId = SelectedCar.BrandId;
                carToEdit.CarName = SelectedCar.CarName;
                carToEdit.Description = SelectedCar.Description;
                carToEdit.BuildYear = SelectedCar.BuildYear;
                carToEdit.Price = SelectedCar.Price;
                carToEdit.Color = SelectedCar.Color;

            }
            else
            {
                EditWindow editWindow = new(SelectedCar);
                editWindow.set_tb_error("Car not found");
            }
            

            
            File.WriteAllText(carsPath, JsonConvert.SerializeObject(CarsCollection));
        }
    }
}
