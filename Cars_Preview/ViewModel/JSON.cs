using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Json;
using System.Windows;
using Cars_Preview.Model;
using Cars_Preview.View;
using System.ComponentModel;

namespace Cars_Preview.ViewModel
{

    class JSON
    {
        public List<Car> JsonCarData()
        {
            string json = File.ReadAllText("../Data.json");
            
            return JsonConvert.DeserializeObject<List<Car>>(json);

                
        }

        //public List<Preview_Car> Preview_CarData()
        //{
        //    List<Car> cars = JsonCarData();
        //    List<Preview_Car> carPreview = new List<Preview_Car>();
        //    foreach (Car car in cars)
        //    {
        //        carPreview.Add(new Preview_Car() { Name = car.Name, Description = car.Description, Price = car.Price });
        //    }
        //    return carPreview;
        //}




        //public void LoadData()
        //{
        //    List<Preview_Car> cars = Preview_CarData();
        //    this.vm_Car = new Vm_Car
        //    {
        //        DataGridItems = cars
        //    };
        //}
    }
}
