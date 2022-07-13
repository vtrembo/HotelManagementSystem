using HotelManager.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Services
{
    public static class CustomExtensions
    {

        //Seeds the database with data
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PorterDTO>().HasData(
                new PorterDTO()
                {
                    IdPerson = 1,
                    IdEmployee = 1,
                    IdPorter = 1,
                    FirstName = "Valerii",
                    LastName = "Trembovetsky",
                    BirthDate = DateTime.Now,
                    PhoneNumber = "888888888",
                    PESEL = "12312332111",
                    HiringDate = DateTime.Now,
                    Workemail = "vtrembovetsky@hotel.com",
                    Password = "password",
                    EnglishLevel = "intermediate"
                });

            modelBuilder.Entity<ApartmentDTO>().HasData(
                new ApartmentDTO()
                {
                    Number = 1,
                    NumberOfBeds = 2,
                    Area = 19.5F,
                    Description = "Description is here.",
                    ApartmentTypes = "Regular"
                },
                new ApartmentDTO()
                {
                    Number = 2,
                    NumberOfBeds = 3,
                    Area = 19.5F,
                    Description = "Description is here.",
                    ApartmentTypes = "Penthouse",
                    HasRoofZone = true
                },
                 new ApartmentDTO()
                 {
                     Number = 3,
                     NumberOfBeds = 2,
                     Area = 19.5F,
                     Description = "Description is here.",
                     ApartmentTypes = "Family",
                     NumberOfChildenBeds = 2
                 });

            modelBuilder.Entity<RoomDTO>().HasData(
                new RoomDTO()
                {
                    IdRoom = 1,
                    Name = "Bedroom",
                    Description = "Quite modern bedroom bla bla",
                    ApartmentNumber = 1
                },
                new RoomDTO()
                {
                    IdRoom = 2,
                    Name = "Bedroom",
                    Description = "Quite modern bedroom bla bla",
                    ApartmentNumber = 2
                },
                new RoomDTO()
                {
                     IdRoom = 3,
                     Name = "Kitchen",
                     Description = "Quite modern kitchen bla bla",
                     ApartmentNumber = 1
                },
                new RoomDTO()
                {
                      IdRoom = 4,
                      Name = "Bedroom",
                      Description = "Quite modern bedroom bla bla",
                      ApartmentNumber = 3
                },
                new RoomDTO() 
                {
                      IdRoom = 5,
                      Name = "Kids Room",
                      Description = "Just after repairs bla bla",
                      ApartmentNumber = 3
                },
                new RoomDTO() 
                {
                      IdRoom = 6,
                      Name = "Hall",
                      Description = "Huge zone for something chillll",
                      ApartmentNumber = 2
                });

            modelBuilder.Entity<FacilityDTO>().HasData(
                new FacilityDTO()
                {
                    IdFacility = 1,
                    Name = "Fride",
                    Price = 140.4F,
                    Weight = 48.4F,
                    Manufacturer = "China",
                    SerialNumber = "SR2312312",
                    IdRoom = 1
                },
                new FacilityDTO()
                {
                    IdFacility = 2,
                    Name = "TV",
                    Price = 249.4F,
                    Weight = 50.4F,
                    Manufacturer = "Samsung",
                    SerialNumber = "SR23123122",
                    IdRoom = 2
                },
                new FacilityDTO()
                {
                    IdFacility = 3,
                    Name = "Carpet",
                    Price = 16.9F,
                    Weight = 9.4F,
                    Manufacturer = "Ukraine",
                    SerialNumber = "SR32312312",
                    IdRoom = 3,
                },
                new FacilityDTO()
                {
                    IdFacility = 4,
                    Name = "Table",
                    Price = 16.9F,
                    Weight = 9.4F,
                    Manufacturer = "Poland SR",
                    IdRoom = 4
                },
                new FacilityDTO()
                {
                    IdFacility = 12,
                    Name = "Table",
                    Price = 16.9F,
                    Weight = 9.4F,
                    Manufacturer = "Poland SR",
                    IdRoom = 5
                },
                new FacilityDTO()
                {
                    IdFacility = 5,
                    Name = "Sofa",
                    Price = 99.9F,
                    Weight = 49.4F,
                    Manufacturer = "Poland SR",
                    IdRoom = 6
                },
                new FacilityDTO()
                {
                    IdFacility = 6,
                    Name = "Mirror",
                    Price = 99.9F,
                    Weight = 10.4F,
                    Manufacturer = "Finland Corp",
                    IdRoom = 1
                },
                new FacilityDTO()
                {
                    IdFacility = 7,
                    Name = "Mirror",
                    Price = 99.9F,
                    Weight = 10.4F,
                    Manufacturer = "Finland Corp",
                    IdRoom = 2
                },
                new FacilityDTO()
                {
                    IdFacility = 8,
                    Name = "Stove",
                    Price = 99.9F,
                    Weight = 10.4F,
                    Manufacturer = "Polska",
                    IdRoom = 3
                },
                new FacilityDTO()
                {
                    IdFacility = 9,
                    Name = "TV",
                    Price = 99.9F,
                    Weight = 10.4F,
                    Manufacturer = "Polska",
                    IdRoom = 4
                },
                new FacilityDTO()
                {
                    IdFacility = 10,
                    Name = "Stove",
                    Price = 99.9F,
                    Weight = 10.4F,
                    Manufacturer = "Polska",
                    IdRoom = 5
                },
                new FacilityDTO()
                {
                    IdFacility = 11,
                    Name = "Dishwasher",
                    Price = 99.9F,
                    Weight = 10.4F,
                    Manufacturer = "Polska",
                    IdRoom = 6
                }
                );

        }
    }
}
