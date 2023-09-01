using Cars_Preview.Global;
using Cars_Preview.Model;
using Cars_Preview.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Cars_Preview.View
{
    /// <summary>
    /// Interaction logic for EditBrands.xaml
    /// </summary>
    public partial class EditBrands : Window
    {
        Vm_EditBrands vm_EditBrands = new();
        public EditBrands()
        {
            InitializeComponent();
            this.DataContext = vm_EditBrands;
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {

            vm_EditBrands.safeBrands();
        }

        private void DeleteSelected_Click(object sender, RoutedEventArgs e)
        {
            if (dg_brands.SelectedItem != null)
            {
                Brand selectedCar = (Brand)dg_brands.SelectedItem;
                vm_EditBrands.deleteBrand(selectedCar);
                dg_brands.Items.Refresh();
            }
        }
        private void NumericOnly(System.Object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            validateEntry.NumericOnly(e);
        }

        private void AlphaNumericOnly(System.Object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            validateEntry.AlphaNumericOnly(e);
        }
    }
}
