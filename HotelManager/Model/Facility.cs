using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Model
{
    public class Facility
    {
        public int IdFacility { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float Weight { get; set; }
        public string Manufacturer { get; set; }
        public string SerialNumber { get; set; }

        public Facility(int id, string name, float price, 
            float weight, string manufacturer, string serialnumber)
        {
            IdFacility = id;
            Name = name;
            Price = price;  
            Weight = weight;
            Manufacturer = manufacturer;
            SerialNumber = serialnumber;

        }
        

        

    }
}
