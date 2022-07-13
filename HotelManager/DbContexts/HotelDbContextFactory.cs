using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DbContexts
{
    public class HotelDbContextFactory
    {
        private readonly string _connectionString;

        public HotelDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public HotelDbContext CreateDbContext()
        {
            //  DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(_connectionString).Options;
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename= C:\\Users\\sweaz\\source\\repos\\vtrembo\\MAS\\Final Project\\HotelManager\\HotelDb.mdf").Options;

            return new HotelDbContext(options);
        }
    }
}
