using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{
    public class ManagerDTO : EmployeeDTO
    {
        public int IdManager { get; set; }
        public string NumberOfSubordinates { get; set; }

        public static string MinimalNumberOfSubordinates { get; set; }
    }
}
