using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{
    public class MaidenDTO : EmployeeDTO
    {
        public int IdMaiden { get; set; }
        public int MinimalAmountOfApartmentsCleaned { get; set; }
        public string SpecializedApartmentType { get; set; }
        public ICollection<FacilityChangeRequestDTO> FacilityChangeRequests { get; set; }
    }
}
