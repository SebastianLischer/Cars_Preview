using System.Text.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System;
using System.Linq;

namespace Cars_Preview.Model
{
    internal class ParrentClass : INotifyPropertyChanged
    {
        public string carsPath = "../Data.json";
        public string brandsPath = "../Brands.json";

        public delegate void UiUpdateNotification(string message);

        public event PropertyChangedEventHandler? PropertyChanged;

        public event UiUpdateNotification uiUpdateNotification;
        //Parameter Definieren??? WO??

        public T loadJson<T>(Type type)
        {
            string jsonString;
            try
            {
                if(type == typeof(Car))
                {
                    jsonString = File.ReadAllText(carsPath);
                }
                else
                {
                    jsonString = File.ReadAllText(brandsPath);
                }
                T objectList = JsonSerializer.Deserialize<T>(jsonString)!;
                return objectList;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found");
                return (T)Activator.CreateInstance(typeof(T));
            }
        }


        private void errorMessage(string message) 
        {
            MessageBox.Show(message);
        }
    }
}
