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
    public class FacilityEntity : IEntityTypeConfiguration<FacilityDTO>
    {
        public void Configure(EntityTypeBuilder<FacilityDTO> builder)
        {

            builder.ToTable("Facility");

            builder.HasKey(e => e.IdFacility);
            builder.Property(e => e.IdFacility).ValueGeneratedOnAdd();

            builder.Property(e => e.Name).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Price).IsRequired();
            builder.Property(e => e.Weight).IsRequired();
            builder.Property(e => e.Manufacturer).IsRequired().HasMaxLength(50);
            builder.Property(e => e.SerialNumber).HasMaxLength(50);

            builder.HasOne(e => e.Room)
                .WithMany(m => m.Facilities)
                .HasForeignKey(m => m.IdRoom)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
