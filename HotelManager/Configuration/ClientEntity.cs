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
    public class ClientEntity : IEntityTypeConfiguration<ClientDTO>
    {
        public void Configure(EntityTypeBuilder<ClientDTO> builder)
        {

            builder.ToTable("Client");

            builder.Property(e => e.IdClient).ValueGeneratedOnAdd();

            builder.Property(e => e.Email).IsRequired().HasMaxLength(50);
        }
    }
}
