using HotelManager.DbContexts;
using HotelManager.DTO;
using HotelManager.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Services.FacilityProvider
{
    public class DatabaseFacilityProvider : IFacilityProvider
    {
        private readonly HotelDbContextFactory _dbContextFactory;

        public DatabaseFacilityProvider(HotelDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<IEnumerable<Facility>> GetAllFacilitiesFromRoom(int roomId)
        {
            using (HotelDbContext context = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<FacilityDTO> facilityDTOs = await context.Facilities.Where(x => x.IdRoom == roomId).ToListAsync();
                return facilityDTOs.Select(r => ToFacilities(r));
            }
        }

        private static Facility ToFacilities(FacilityDTO dto)
        {
            return new Facility(dto.IdFacility, dto.Name, dto.Price, dto.Weight, dto.Manufacturer, dto.SerialNumber);
        }
    }
}
