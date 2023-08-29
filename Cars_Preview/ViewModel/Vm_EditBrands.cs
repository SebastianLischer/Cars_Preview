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
        public ObservableCollection<Brand> BrandsCollection { get; set; }

        
        public Vm_EditBrands()
        {
            loadBrands();
            //BrandsCollection.CollectionChanged += BrandsCollection_CollectionChanged;
        }

        //private void BrandsCollection_CollectionChanged(/*object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e*/)
        //{
        //    if (e.Action == NotifyCollectionChangedAction.Add)
        //    {
        //        foreach (Brand newItem in e.NewItems)
        //        {
        //           if(validateBrandId(newItem.Id))
        //            {
        //                BrandsCollection.RemoveAt(BrandsCollection.Count - 1);
        //            }
        //        }
        //    }
        //}

        string brandsPath = "../Brands.json";
        public void loadBrands()
        {

            string json = File.ReadAllText(brandsPath);
            BrandsCollection = JsonConvert.DeserializeObject<ObservableCollection<Brand>>(json);
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
        public bool validateBrandId(int id)
        {
            if (id < 0)
            {
                MessageBox.Show("Id must be greater than 0");
                return false;
            }
            else
            {
                foreach (Brand brand in BrandsCollection)
                {
                    if (brand.Id == id)
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
