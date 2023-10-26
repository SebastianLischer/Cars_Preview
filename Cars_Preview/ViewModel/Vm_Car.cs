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
using System.Windows.Shapes;
using Cars_Preview.Model;
using Cars_Preview.View;
using Newtonsoft.Json;

namespace Cars_Preview.ViewModel
{
    class Vm_Car : ParrentClass
    {
        public List<Car> CarsCollection { get; set; }
        public List<Brand> BrandCollection { get; set; }

        public Vm_Car()
        {
            var carsCollection = this.loadJson<List<Car>>(typeof(Car));
            CarsCollection = carsCollection;
            var brandCollection = this.loadJson<List<Brand>>(typeof(Brand));
            BrandCollection = brandCollection;
        }

        public void safeCars()
        {
            File.WriteAllText(carsPath, JsonConvert.SerializeObject(CarsCollection));
        }

        public void refreshBrands(DataGrid dataGrid)
        {
            var carsCollection = this.loadJson<List<Car>>(typeof(Car));
            CarsCollection = carsCollection;
            var brandCollection = this.loadJson<List<Brand>>(typeof(Brand));
            BrandCollection = brandCollection;
            dataGrid.Items.Refresh();
        }
    }
}

