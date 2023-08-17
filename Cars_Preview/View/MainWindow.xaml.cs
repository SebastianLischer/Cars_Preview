using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
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
        Vm_Car vm_Car = new Vm_Car();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm_Car;
        }

        public void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            this.vm_Car.safeCars();
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            EditWindow ew = new EditWindow();
            ew.Show();
        }
    }
}
