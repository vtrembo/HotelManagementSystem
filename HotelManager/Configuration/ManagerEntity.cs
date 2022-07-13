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
    public class ManagerEntity : IEntityTypeConfiguration<ManagerDTO>
    {
        public void Configure(EntityTypeBuilder<ManagerDTO> builder)
        {

            builder.ToTable("Manager");

            builder.Property(e => e.IdManager).ValueGeneratedOnAdd();

            builder.Property(e => e.NumberOfSubordinates).IsRequired().HasMaxLength(12);
        }
    }
}
