using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{
    public class FacilityDTO
    {
        public int IdFacility { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float Weight { get; set; }
        public string Manufacturer { get; set; }
        public string SerialNumber { get; set; }
        public int IdRoom { get; set; }
        public RoomDTO Room { get; set; }

        public ICollection<DamageReportDTO> DamageReports { get; set; }

    }
}
