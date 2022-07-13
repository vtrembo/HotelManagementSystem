using HotelManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.ViewModel
{


    /// <summary>
    /// Displaying values of "Room" ViewModel
    /// </summary>
    public class RoomViewModel : ViewModelBase
    {
        private readonly Room _room;

        public int Id => _room.IdRoom;
        public string Name => _room.Name;
        public string Price => _room.Description;

        public RoomViewModel(Room room)
        {
            _room = room;
        }
    }
}
