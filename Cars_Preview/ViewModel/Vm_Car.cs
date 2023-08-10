using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Cars_Preview.Model;
using Cars_Preview.View;

namespace Cars_Preview.ViewModel
{
    class Vm_Car : INotifyPropertyChanged
    {
        //private int _gluecksZahl;
        public event PropertyChangedEventHandler? PropertyChanged;
        List<Car> _CarsCollection = new List<Car>();

        public Vm_Car()
        {
            //this.GluecksZahl = loadDataFile();
            this.loadCars();
        }


        public void loadCars()
        {
            
            _CarsCollection.Add(new Car() { Name = "Audi", Description = "moderner Sportwagen", Price = 444444 });
            _CarsCollection.Add(new Car() { Name = "Porsche", Description = "moderner Sportwagen", Price = 444444 });
            _CarsCollection.Add(new Car() { Name = "Bugatti", Description = "moderner Sportwagen", Price = 444444 });
            _CarsCollection.Add(new Car() { Name = "VW", Description = "moderner Sportwagen", Price = 444444 });
        }




        public List<Car> CarsCollection
        {
            get
            {
                return _CarsCollection;
            }
            set
            {
                _CarsCollection = value;
                OnPropertyChanged();
            }
        }




        //public int GluecksZahl
        //{
        //    get
        //    {
        //        return _gluecksZahl;
        //    }
        //    set
        //    {
        //        _gluecksZahl = value;
        //        OnPropertyChanged();
        //    }
        //}

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            var handler = PropertyChanged;
            if (handler != null && name != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}

