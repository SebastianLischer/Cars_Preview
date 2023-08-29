using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Preview.Model
{
    public class Car
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string CarName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int BuildYear { get; set; }
        public int Price { get; set; }
        public string Color { get; set; } = string.Empty;

    }
}
