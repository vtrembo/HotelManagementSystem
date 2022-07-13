using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{
    public class RoomDTO
    {
        public int IdRoom { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int ApartmentNumber { get; set; }
        public ApartmentDTO Apartment { get; set; }
        public ICollection<FacilityDTO> Facilities { get; set; }


    }
}
