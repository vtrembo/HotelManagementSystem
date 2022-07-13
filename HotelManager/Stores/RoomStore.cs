using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Stores
{
    public class RoomStore
    {
        public event Action<int> RoomCreated;
        public void CreateRoom(int roomId)
        {
            RoomCreated?.Invoke(roomId);
        }
    }
}
