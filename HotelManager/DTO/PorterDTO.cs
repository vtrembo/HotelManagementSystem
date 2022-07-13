using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{
    public class PorterDTO : EmployeeDTO
    {
        public int IdPorter { get; set; }
        public string EnglishLevel { get; set; }
        public ICollection<ReservationDTO> Reservations { get; set; }
        public ICollection<DamageReportDTO> DamageReports { get; set; }

    }
}
