using HotelManager.DbContexts;
using HotelManager.DTO;
using HotelManager.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Services.ApartmentProvider
{
    public class DatabaseApartmentProvider : IApartmentProvider
    {
        private readonly HotelDbContextFactory _dbContextFactory;

        public DatabaseApartmentProvider(HotelDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<IEnumerable<Apartment>> GetAllApartments()
        {
            using (HotelDbContext context = _dbContextFactory.CreateDbContext())
            {


                IEnumerable<ApartmentDTO> apartmentDTOs = await context.Apartments.ToListAsync();

                return apartmentDTOs.Select(r => ToApartments(r));
            }
        }

        private static Apartment ToApartments(ApartmentDTO dto)
        {
            return new Apartment(dto.Number, dto.NumberOfBeds, dto.Area, dto.Description);
        }
    }
}
