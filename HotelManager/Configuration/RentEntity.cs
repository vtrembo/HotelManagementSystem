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
    public class RentEntity : IEntityTypeConfiguration<RentDTO>
    {
        public void Configure(EntityTypeBuilder<RentDTO> builder)
        {
           
            builder.ToTable("Rent");

            builder.HasKey(e => new { e.IdClient, e.ApartmentNumber});

            builder.Property(e => e.StartDate).IsRequired();
            builder.Property(e => e.EndDate).IsRequired();
            
            builder.HasOne(e => e.Client)
                .WithMany(m => m.Rents)
                .HasForeignKey(m => m.IdClient)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Apartment)
                .WithMany(m => m.Rents)
                .HasForeignKey(m => m.ApartmentNumber)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
