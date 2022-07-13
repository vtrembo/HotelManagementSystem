using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Model
{
    public class DamageReport
    {
        public int IdDamageReport { get; set; }
        public string Description { get; set; }
        public int IdFacility { get; set; }

        public DamageReport(int idDamageReport, string description, int idFacility)
        {
            IdDamageReport = idDamageReport;
            Description = description;
            IdFacility = idFacility;
        }
        public DamageReport(string description, int idFacility)
        {
            Description = description;
            IdFacility = idFacility;
        }
    }
}
