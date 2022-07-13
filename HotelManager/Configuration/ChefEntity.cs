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
    public class ChefEntity : IEntityTypeConfiguration<ChefDTO>
    {
        public void Configure(EntityTypeBuilder<ChefDTO> builder)
        {

            builder.ToTable("Chef");

            builder.Property(e => e.IdChef).ValueGeneratedOnAdd();

            builder.Property(e => e.SpecifiedCuisine).IsRequired().HasMaxLength(50);

            builder.HasOne(e => e.Restaurant)
                .WithMany(m => m.Chefs)
                .HasForeignKey(m => m.IdRestaurant)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
