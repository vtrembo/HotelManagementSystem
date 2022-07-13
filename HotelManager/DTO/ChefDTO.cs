using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{
    public class ChefDTO : EmployeeDTO
    {
        public int IdChef { get; set; }
        public string SpecifiedCuisine { get; set; }

        public int IdRestaurant { get; set; }
        public RestaurantDTO Restaurant { get; set; }
    }
}
