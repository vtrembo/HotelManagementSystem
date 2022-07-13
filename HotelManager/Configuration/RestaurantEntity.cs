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
    public class RestaurantEntity : IEntityTypeConfiguration<RestaurantDTO>
    {
        public void Configure(EntityTypeBuilder<RestaurantDTO> builder)
        {

            builder.ToTable("Restaurant");

            builder.HasKey(e => e.IdRestaurant);
            builder.Property(e => e.IdRestaurant).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(30);

            builder.HasOne(e => e.Menu).
                WithOne(e => e.Restaurant).
                HasForeignKey<MenuDTO>(a => a.IdRestaurant).
                OnDelete(DeleteBehavior.Restrict); ;

        }
    }
}
