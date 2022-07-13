using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{
    public class RentDTO
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float TotalPrice { get; set; }

        public int IdClient { get; set; }
        public ClientDTO Client { get; set; }

        public int ApartmentNumber { get; set; }
        public ApartmentDTO Apartment { get; set; }
    }
}
