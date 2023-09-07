using Cars_Preview.ViewModel;
using Cars_Preview.Model;
using Cars_Preview.Global;
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
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        Vm_EditCar vm_EditCar = new();
        public EditWindow(Car selectedCar)
        {
            InitializeComponent();
            this.vm_EditCar.SelectedCar = selectedCar;
            this.DataContext = vm_EditCar;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.vm_EditCar.safeCars();//Muss der Vm_EditCar übergeben werden???
        }

        private void NumericOnly(System.Object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            validateEntry.NumericOnly(e);
        }

        private void AlphaNumericOnly(System.Object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            validateEntry.AlphaNumericOnly(e);
        }

        //set error message in the tb_error textblock
        public void set_tb_error(string message)
        {
            if (tb_error.Text == "")
            {
                tb_error.Text = message;
                tb_error.Visibility = Visibility.Visible;
            }
            else
            {
                tb_error.Visibility = Visibility.Hidden;
            }
        }
    }
}
