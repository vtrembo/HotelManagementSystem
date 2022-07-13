using HotelManager.DbContexts;
using HotelManager.DTO;
using HotelManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Services.DamageReportCreator
{
    public class DatabaseDamageReportCreator : IDamageReportCreator
    {
        private readonly HotelDbContextFactory _dbContextFactory;

        public DatabaseDamageReportCreator(HotelDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }
        public async Task CreateDamageReport(DamageReport damageReport)
        {
            using (HotelDbContext context = _dbContextFactory.CreateDbContext())
            {


                DamageReportDTO damageReportDTO = ToDamageReportDTO(damageReport);

                context.DamageReports.Add(damageReportDTO);
                await context.SaveChangesAsync();
            }
        }

        private DamageReportDTO ToDamageReportDTO(DamageReport damageReport)
        {
            return new DamageReportDTO()
            {
                Description = damageReport.Description,
                DateOfCreation = DateTime.Now,
                IdFacility = damageReport.IdFacility,
                IdPorter = 1
            };
        }
    }
}
