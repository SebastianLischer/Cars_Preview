using System.Collections.Generic;
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
        public List<Brand> BrandsCollection { get; set; }

        public Vm_EditBrands()
        {
            BrandsCollection = loadBrands();
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
