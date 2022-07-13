using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{
    public enum RequestStatus
    {
        WaitingForReview,
        WaitingForDecision,
        Approved,
        Rejected,
        Archieved
    }
    public class FacilityChangeRequestDTO
    {
        public int IdFacilityChangeRequest { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime? DateOfDecision { get; set; }
        public bool? Approved { get; set; }
        public RequestStatus Status { get; set; }
        public string Description { get; set; }
        public int IdMaiden { get; set; }
        public MaidenDTO Maiden { get; set; }
        public int IdDamageReport { get; set; }
        public DamageReportDTO DamageReport { get; set; }
    }
}
