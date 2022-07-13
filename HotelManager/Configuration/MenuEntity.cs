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
    public class MenuEntity : IEntityTypeConfiguration<MenuDTO>
    {
        public void Configure(EntityTypeBuilder<MenuDTO> builder)
        {

            builder.ToTable("Menu");

            builder.HasKey(e => e.IdRestaurant);

            builder.Property(e => e.Name).IsRequired().HasMaxLength(30);


        }
    }
}
