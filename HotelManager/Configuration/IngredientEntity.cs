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
    public class IngredientEntity : IEntityTypeConfiguration<IngredientDTO>
    {
        public void Configure(EntityTypeBuilder<IngredientDTO> builder)
        {

            builder.ToTable("Ingredient");

            builder.HasKey(e => e.IdIngredient);
            builder.Property(e => e.IdIngredient).ValueGeneratedOnAdd();

            builder.Property(e => e.Name).IsRequired().HasMaxLength(30);
            builder.Property(e => e.IsVegeterian).IsRequired();

        }
    }
}
