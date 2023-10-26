using Cars_Preview.Global;
using Cars_Preview.Model;
using Cars_Preview.ViewModel;
using System.Windows;

namespace Cars_Preview.View
{
    /// <summary>
    /// Interaction logic for EditBrands.xaml
    /// </summary>
    public partial class EditBrands : Window
    {
        Vm_EditBrands vm_EditBrands = new();
        private int nextID = 1;
        public EditBrands() 
        {
            InitializeComponent();
            this.DataContext = vm_EditBrands;
            //vm_EditBrands.BrandsCollection = new ObservableCollection<Brand>();
            //dg_brands.ItemsSource = vm_EditBrands.BrandsCollection;
            //dg_brands.AddingNewItem += DataGrid_AddingNewItem;
        }

        //private void DataGrid_AddingNewItem(object sender, AddingNewItemEventArgs e)
        //{
        //    // Find the maximum ID value in the current data items
        //    int maxId = vm_EditBrands.BrandsCollection.Count > 0 ? vm_EditBrands.BrandsCollection.Max(item => item.Id) : 0;

        //    // Increment the ID for the new item
        //    var newItem = new Brand { Id = maxId + 1 };

        //    // Add the new item to the collection
        //    vm_EditBrands.BrandsCollection.Add(newItem);

        //    // Set the newly created item as the added item
        //    e.NewItem = newItem;
        //}
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
