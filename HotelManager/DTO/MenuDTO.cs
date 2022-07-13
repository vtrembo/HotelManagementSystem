using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{
    public class MenuDTO
    {
        public string Name { get; set; }

        public int IdRestaurant { get; set; }
        public RestaurantDTO Restaurant{ get; set; }
        public ICollection<DishDTO> Dishes { get; set; }

    }
}
