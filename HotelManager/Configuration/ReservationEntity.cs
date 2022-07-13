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
    public class ReservationEntity : IEntityTypeConfiguration<ReservationDTO>
    {
        public void Configure(EntityTypeBuilder<ReservationDTO> builder)
        {
           
            builder.ToTable("Reservation");

            builder.HasKey(e => new { e.IdPorter, e.TableNumber});

            builder.Property(e => e.DateOfReservation).IsRequired();
            builder.Property(e => e.DateOfReservationCreation).IsRequired();
            
            builder.HasOne(e => e.Porter)
                .WithMany(m => m.Reservations)
                .HasForeignKey(m => m.IdPorter)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
