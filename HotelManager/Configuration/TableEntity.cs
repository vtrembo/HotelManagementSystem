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
    public class TableEntity : IEntityTypeConfiguration<TableDTO>
    {
        public void Configure(EntityTypeBuilder<TableDTO> builder)
        {
           
            builder.ToTable("Table");

            builder.HasKey(e => e.Number);
            builder.Property(e => e.Number).ValueGeneratedOnAdd();

            builder.Property(e => e.NumberOfSeats).IsRequired();
            builder.Property(e => e.IsIndoor).IsRequired();
            builder.Property(e => e.IsOutdoor).IsRequired();
            builder.Property(e => e._HasUmbrella).IsRequired().HasColumnName("HasUmbrella");
            builder.Property(e => e._IsInSmokingAre).IsRequired().HasColumnName("IsInSmokingAre");

            builder.HasOne(e => e.Restaurant)
                .WithMany(m => m.Tables)
                .HasForeignKey(m => m.IdRestaurant)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Reservation).
                WithOne(e => e.Table).
                HasForeignKey<ReservationDTO>(a => a.TableNumber).
                OnDelete(DeleteBehavior.Restrict);

            builder.Ignore(e => e.HasUmbrella);
            builder.Ignore(e => e.IsInSmokingAre);
        }
    }
}
