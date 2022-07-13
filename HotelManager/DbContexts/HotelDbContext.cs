using HotelManager.Configuration;
using HotelManager.DTO;
using HotelManager.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DbContexts
{
    public class HotelDbContext : DbContext
    {

        public HotelDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PersonDTO> Persons { get; set; }
        public DbSet<ClientDTO> Clients { get; set; }
        public DbSet<RentDTO> Rents{ get; set; }
        public DbSet<ApartmentDTO> Apartments { get; set; }
        public DbSet<RoomDTO> Rooms { get; set; }
        public DbSet<FacilityDTO> Facilities { get; set; }
        public DbSet<ManagerDTO> Managers { get; set; }
        public DbSet<MaidenDTO> Maidens { get; set; }
        public DbSet<PorterDTO> Porters { get; set; }
        public DbSet<ChefDTO> Chefs { get; set; }
        public DbSet<RestaurantDTO> Restaurants { get; set; }
        public DbSet<MenuDTO> Menus { get; set; }
        public DbSet<DishDTO> Dishes { get; set; }
        public DbSet<IngredientDishDTO> IgredientDishes { get; set; }
        public DbSet<IngredientDTO> Ingredients{ get; set; }
        public DbSet<ReservationDTO> Reservations{ get; set; }
        public DbSet<TableDTO> Tables { get; set; }
        public DbSet<FacilityChangeRequestDTO> FacilityChangeRequests { get; set; }
        public DbSet<DamageReportDTO> DamageReports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PersonEntity());
            modelBuilder.ApplyConfiguration(new ClientEntity());
            modelBuilder.ApplyConfiguration(new RentEntity());
            modelBuilder.ApplyConfiguration(new ApartmentEntity());
            modelBuilder.ApplyConfiguration(new RoomEntity());
            modelBuilder.ApplyConfiguration(new FacilityEntity());
            modelBuilder.ApplyConfiguration(new ManagerEntity());
            modelBuilder.ApplyConfiguration(new MaidenEntity());
            modelBuilder.ApplyConfiguration(new PorterEntity());
            modelBuilder.ApplyConfiguration(new ChefEntity());
            modelBuilder.ApplyConfiguration(new RestaurantEntity());
            modelBuilder.ApplyConfiguration(new MenuEntity());
            modelBuilder.ApplyConfiguration(new DishEntity());
            modelBuilder.ApplyConfiguration(new IngredientDishEntity());
            modelBuilder.ApplyConfiguration(new IngredientEntity());
            modelBuilder.ApplyConfiguration(new ReservationEntity());
            modelBuilder.ApplyConfiguration(new TableEntity());
            modelBuilder.ApplyConfiguration(new FacilityChangeRequestEntity());
            modelBuilder.ApplyConfiguration(new DamageReportEntity());

            modelBuilder.Seed();

        }
    }
}
