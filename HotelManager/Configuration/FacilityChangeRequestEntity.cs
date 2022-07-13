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
    public class FacilityChangeRequestEntity : IEntityTypeConfiguration<FacilityChangeRequestDTO>
    {
        public void Configure(EntityTypeBuilder<FacilityChangeRequestDTO> builder)
        {
           
            builder.ToTable("FacilityChangeRequest");

            builder.HasKey(e => e.IdFacilityChangeRequest);
            builder.Property(e => e.IdFacilityChangeRequest).ValueGeneratedOnAdd();

            builder.Property(e => e.Status).IsRequired();
            builder.Property(e => e.DateOfCreation).IsRequired();
            builder.Property(e => e.Description).IsRequired().HasMaxLength(300);

            builder.HasOne(e => e.Maiden)
                .WithMany(e => e.FacilityChangeRequests)
                .HasForeignKey(e => e.IdMaiden)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
