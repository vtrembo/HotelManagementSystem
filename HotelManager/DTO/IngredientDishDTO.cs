using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{
    public class IngredientDishDTO
    {
        public int IdDish { get; set; }
        public int IdIngredient { get; set; }
        public IngredientDTO Ingredient { get; set; }
        public DishDTO Dish { get; set; }
    }
}
