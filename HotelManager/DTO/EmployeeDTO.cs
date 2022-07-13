using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{
    public abstract class EmployeeDTO : PersonDTO
    {
        public int IdEmployee { get; set; }
        public string PESEL { get; set; }
        public DateTime HiringDate { get; set; }
        public DateTime? LeavingDate { get; set; }
        public string Workemail { get; set; }
        public string Password { get; set; }
    }
}
