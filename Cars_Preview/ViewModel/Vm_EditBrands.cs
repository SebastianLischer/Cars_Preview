using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using Cars_Preview.Model;
using Newtonsoft.Json;

namespace Cars_Preview.ViewModel
{
    internal class Vm_EditBrands : ParrentClass
    {
        public ObservableCollection<Brand> BrandsCollection { get; set; }

        public Vm_EditBrands()
        {
            BrandsCollection = LoadBrands();
        }

        public ObservableCollection<Brand> LoadBrands()
        {
            try
            {
                string json = File.ReadAllText(brandsPath);
                return JsonConvert.DeserializeObject<ObservableCollection<Brand>>(json);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found");
                return null;
            }
        }
        public void safeBrands()
        {
            File.WriteAllText(brandsPath, JsonConvert.SerializeObject(BrandsCollection));
        }

        public void deleteBrand(Brand brand)
        {
            BrandsCollection.Remove(brand);
            safeBrands();
        }

    }
}
