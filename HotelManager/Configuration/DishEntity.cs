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
    public class DishEntity : IEntityTypeConfiguration<DishDTO>
    {
        public void Configure(EntityTypeBuilder<DishDTO> builder)
        {
           
            builder.ToTable("Dish");

            builder.HasKey(e => e.IdDish);
            builder.Property(e => e.IdDish).ValueGeneratedOnAdd();

            builder.Property(e => e.Name).IsRequired().HasMaxLength(30);
            builder.Property(e => e.Cuisine).IsRequired().HasMaxLength(30);
            builder.Property(e => e.IsVegeterian).IsRequired();

            builder.HasOne(e => e.Menu)
                .WithMany(m => m.Dishes)
                .HasForeignKey(m => m.IdMenu)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
