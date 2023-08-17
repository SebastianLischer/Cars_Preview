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
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        Vm_Car vm_Car = new Vm_Car();
        public EditWindow()
        {
            InitializeComponent();
            this.DataContext = vm_Car;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm_Car.safeCars();
        }
    }
}
