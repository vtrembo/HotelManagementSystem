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
    public class EmployeeEntity : IEntityTypeConfiguration<EmployeeDTO>
    {
        public void Configure(EntityTypeBuilder<EmployeeDTO> builder)
        {

            builder.ToTable("Employee");

            builder.Property(e => e.IdEmployee).ValueGeneratedOnAdd();


            builder.Property(e => e.PESEL).IsRequired().HasMaxLength(11);
            builder.Property(e => e.Workemail).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Password).IsRequired().HasMaxLength(50);
        }
    }
}
