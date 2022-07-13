using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{
    public class ReservationDTO
    {
        public DateTime DateOfReservation { get; set; }
        public DateTime DateOfReservationCreation { get; set; }

        public int IdPorter { get; set; }
        public PorterDTO Porter { get; set; }

        public int TableNumber { get; set; }
        public TableDTO Table { get; set; }
    }
}
