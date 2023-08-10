using System.Collections.Generic;
using System.Windows;
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
        
        public MainWindow()
        {
            Vm_Car vm_Car = new Vm_Car();
            InitializeComponent();
            this.DataContext = vm_Car;

        }

        //private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    //FullCarView fcv = new FullCarView();
        //    //fcv.Show();
        //}
    }
}
