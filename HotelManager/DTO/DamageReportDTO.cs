using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{
    public class DamageReportDTO
    {
        public int IdDamageReport { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string Description { get; set; }
        public int IdFacility { get; set; }
        public FacilityDTO Facility { get; set; }
        public int IdPorter { get; set; }
        public PorterDTO Porter { get; set; }
        public FacilityChangeRequestDTO FacilityChangeRequest { get; set; }


    }
}
