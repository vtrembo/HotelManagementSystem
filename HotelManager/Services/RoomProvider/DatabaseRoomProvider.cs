using HotelManager.DbContexts;
using HotelManager.DTO;
using HotelManager.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Services.RoomProvider
{
    public class DatabaseRoomProvider : IRoomProvider
    {
        private readonly HotelDbContextFactory _dbContextFactory;

        public DatabaseRoomProvider(HotelDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<IEnumerable<Room>> GetAllRoomsFrom(int apartmentNumber)
        {
            using (HotelDbContext context = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<RoomDTO> roomDTOs = await context.Rooms.Where(x => x.ApartmentNumber == apartmentNumber).ToListAsync();
                return roomDTOs.Select(r => ToRooms(r));
            }
        }

        private static Room ToRooms(RoomDTO dto)
        {
            return new Room(dto.IdRoom, dto.Name, dto.Description);
        }
    }
}
