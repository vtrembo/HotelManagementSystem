using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DbContexts
{
    public class HotelDesignTimeDbContextFactory : IDesignTimeDbContextFactory<HotelDbContext>
    {
        public HotelDbContext CreateDbContext(string[] args)
        {
            // DbContextOptions options = new DbContextOptionsBuilder().UseSqlite("Data Source = hoteldb.db").Options;
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename= C:\\Users\\sweaz\\source\\repos\\vtrembo\\MAS\\Final Project\\HotelManager\\HotelDb.mdf").Options;

            return new HotelDbContext(options);
        }
    }
}
