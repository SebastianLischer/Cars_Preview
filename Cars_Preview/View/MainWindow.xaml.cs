using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Cars_Preview.Global;
using Cars_Preview.Model;
using Cars_Preview.ViewModel;

namespace Cars_Preview.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        Vm_Car vm_Car = new();
        public MainWindow()
        {
            InitializeComponent();//
            this.DataContext = vm_Car;
        }

        public void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            this.vm_Car.safeCars();
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            Car car = (Car)dgPreview.SelectedItem;
            EditWindow ew = new(car);
            ew.Show();
        }

        private void Button_EditBrands_Click(object sender, RoutedEventArgs e)
        {
            EditBrands eb = new EditBrands();
            eb.Show();
            //When the EditBrands window is closed, the datagrid is refreshed
            eb.Closed += (s, args) => { vm_Car.refreshBrands(dgPreview); };
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
