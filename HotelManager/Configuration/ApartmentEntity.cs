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
    public class ApartmentEntity : IEntityTypeConfiguration<ApartmentDTO>
    {
        public void Configure(EntityTypeBuilder<ApartmentDTO> builder)
        {

            builder.ToTable("Apartment");

            builder.HasKey(e => e.Number);
            builder.Property(e => e.Number).ValueGeneratedOnAdd();

            builder.Property(e => e.NumberOfBeds).IsRequired();
            builder.Property(e => e.Area).IsRequired();
            builder.Property(e => e.Description).IsRequired().HasMaxLength(300);
            builder.Property(e => e.ApartmentTypes).IsRequired().HasMaxLength(50);

        }
    }
}
