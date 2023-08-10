using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Preview.Model
{
    internal class Car
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int BuildYear { get; set; }
        public int Price { get; set; }
        public string Color { get; set; } = string.Empty;


        //public Car(int id, string name, string description, int buildYear, int price, string color)
        //{
        //    Id = id;
        //    Name = name;
        //    Description = description;
        //    BuildYear = buildYear;
        //    Price = price;
        //    Color = color;
        //}

    }
}
