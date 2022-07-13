using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{
    public class RestaurantDTO
    {
        public int IdRestaurant { get; set; }
        public string Name { get; set; }
        public MenuDTO Menu { get; set; }
        public ICollection<ChefDTO> Chefs { get; set; }
        public ICollection<TableDTO> Tables { get; set; }
    }
}
