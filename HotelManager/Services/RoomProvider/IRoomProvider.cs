﻿using HotelManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Services.RoomProvider
{
    public interface IRoomProvider
    {
        Task<IEnumerable<Room>> GetAllRoomsFrom(int apartmentNumber);
    }
}
