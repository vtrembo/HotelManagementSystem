using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{


    public class ApartmentDTO
    {
        public int Number { get; set; }
        public int NumberOfBeds { get; set; }
        public float Area { get; set; }
        public string Description { get; set; }
        public string ApartmentTypes { get; set; }

        public int? AmountOfDrinks { get; set; }

        public int? NumberOfChildenBeds { get; set; }
       
        public bool? HasRoofZone { get; set; }


        public ICollection<RentDTO> Rents { get; set; }

        public ICollection<RoomDTO> Rooms { get; set; }

    }
}
