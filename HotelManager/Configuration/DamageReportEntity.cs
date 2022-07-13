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
    public class DamageReportEntity : IEntityTypeConfiguration<DamageReportDTO>
    {
        public void Configure(EntityTypeBuilder<DamageReportDTO> builder)
        {
           
            builder.ToTable("DamageReport");

            builder.HasKey(e => e.IdDamageReport);
            builder.Property(e => e.IdDamageReport).ValueGeneratedOnAdd();

            builder.Property(e => e.DateOfCreation).IsRequired();
            builder.Property(e => e.Description).IsRequired().HasMaxLength(300);


            builder.HasOne(e => e.Porter)
                .WithMany(m => m.DamageReports)
                .HasForeignKey(m => m.IdPorter)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Facility)
                .WithMany(m => m.DamageReports)
                .HasForeignKey(m => m.IdFacility)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.FacilityChangeRequest).
                WithOne(e => e.DamageReport).
                HasForeignKey<FacilityChangeRequestDTO>(a => a.IdDamageReport).
                OnDelete(DeleteBehavior.Restrict);

        }
    }
}
