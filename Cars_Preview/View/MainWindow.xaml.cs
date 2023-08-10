using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
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
            Brand.ItemsSource = vm_Car.getBrand();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.vm_Car.safeCars();
        }

        //private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    //FullCarView fcv = new FullCarView();
        //    //fcv.Show();
        //}
    }
}
