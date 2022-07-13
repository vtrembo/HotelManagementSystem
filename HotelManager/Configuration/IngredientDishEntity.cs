using HotelManager.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Configuration
{
    public class IngredientDishEntity : IEntityTypeConfiguration<IngredientDishDTO>
    {
        public void Configure(EntityTypeBuilder<IngredientDishDTO> builder)
        {
           
            builder.ToTable("IngredientDish");

            builder.HasKey(e => new { e.IdDish, e.IdIngredient});
 
            builder.HasOne(e => e.Dish)
                .WithMany(m => m.Ingredients)
                .HasForeignKey(m => m.IdDish)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Ingredient)
                .WithMany(m => m.Dishes)
                .HasForeignKey(m => m.IdIngredient)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
