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
    public class PorterEntity : IEntityTypeConfiguration<PorterDTO>
    {
        public void Configure(EntityTypeBuilder<PorterDTO> builder)
        {

            builder.ToTable("Porter");

            builder.Property(e => e.IdPorter).ValueGeneratedOnAdd();

            builder.Property(e => e.EnglishLevel).IsRequired().HasMaxLength(30);
        }
    }
}
