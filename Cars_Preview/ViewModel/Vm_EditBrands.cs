using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Cars_Preview.Model;
using Newtonsoft.Json;

namespace Cars_Preview.ViewModel
{
    internal class Vm_EditBrands : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;


        public Vm_EditBrands()
        {
            loadBrands();
        }
        public List<Brand> _BrandsCollection { get; set; }
        //add value to _BrandsCollection


        public List<Brand> BrandsCollection
        {
            get { return BrandsCollection; }
            set
            {
                BrandsCollection = value;
                OnPropertyChanged();
                
            }
        }


        string brandsPath = "../Brands.json";
        public void loadBrands()
        {

            string json = File.ReadAllText(brandsPath);
            BrandsCollection = JsonConvert.DeserializeObject<List<Brand>>(json);
        }
        public void safeBrands()
        {
            File.WriteAllText(brandsPath, JsonConvert.SerializeObject(BrandsCollection));
        }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            var handler = PropertyChanged;
            if (handler != null && name != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        //Delete Brand
        public void deleteBrand(Brand brand)
        {
            BrandsCollection.Remove(brand);
            safeBrands();
        }

        //Validate Brand Id and check if it is already in use
        public bool validateBrandId(List<Brand> brandList)
        {
            int lastAddedId = brandList.Count > 0 ? brandList[brandList.Count - 1].Id : -1;
            if (lastAddedId < 0)
            {
                MessageBox.Show("Id must be greater than 0");
                return false;
            }
            else
            {
                foreach (Brand brand in BrandsCollection)
                {
                    if (brand.Id == lastAddedId)
                    {
                        MessageBox.Show("Id already in use");
                        return false;
                    }
                }
                return true;
            }
        }


    }
}
