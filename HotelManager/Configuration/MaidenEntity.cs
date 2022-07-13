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
    public class MaidenEntity : IEntityTypeConfiguration<MaidenDTO>
    {
        public void Configure(EntityTypeBuilder<MaidenDTO> builder)
        {

            builder.ToTable("Maiden");

            builder.Property(e => e.IdMaiden).ValueGeneratedOnAdd();

            builder.Property(e => e.MinimalAmountOfApartmentsCleaned).IsRequired().HasMaxLength(12);
            builder.Property(e => e.SpecializedApartmentType).IsRequired().HasMaxLength(50);
        }
    }
}
