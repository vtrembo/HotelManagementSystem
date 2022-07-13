using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{
    public class IngredientDTO
    {
        public int IdIngredient { get; set; }
        public string Name { get; set; }
        public bool IsVegeterian { get; set; }
        public ICollection<IngredientDishDTO> Dishes { get; set; }

    }
}
