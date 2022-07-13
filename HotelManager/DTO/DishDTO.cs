using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{
    public class DishDTO
    {
        public int IdDish { get; set; }
        public string Name { get; set; }
        public string Cuisine { get; set; }
        public bool IsVegeterian { get; set; }

        public int IdMenu { get; set; }
        public MenuDTO Menu { get; set; }

        public ICollection<IngredientDishDTO> Ingredients { get; set; }

    }
}
