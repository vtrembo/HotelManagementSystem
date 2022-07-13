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
    public class PersonEntity : IEntityTypeConfiguration<PersonDTO>
    {
        public void Configure(EntityTypeBuilder<PersonDTO> builder)
        {

            builder.ToTable("Person");

            builder.HasKey(e => e.IdPerson);
            builder.Property(e => e.IdPerson).ValueGeneratedOnAdd();

            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(e => e.BirthDate).IsRequired();
            builder.Property(e => e.PhoneNumber).IsRequired().HasMaxLength(9);
        }
    }
}
