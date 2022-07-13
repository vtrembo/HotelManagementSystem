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
    public class RoomEntity : IEntityTypeConfiguration<RoomDTO>
    {
        public void Configure(EntityTypeBuilder<RoomDTO> builder)
        {

            builder.ToTable("Room");

            builder.HasKey(e => e.IdRoom);


            builder.Property(e => e.Name).IsRequired().HasMaxLength(30);

            builder.Property(e => e.Description).HasMaxLength(300);


            builder.HasOne(e => e.Apartment)
                .WithMany(m => m.Rooms)
                .HasForeignKey(m => m.ApartmentNumber)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
