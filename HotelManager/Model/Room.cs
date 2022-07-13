using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Model
{
    public class Room
    {
        public int IdRoom { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Room(int id, string name, string description)
        {
            IdRoom = id;
            Name = name;
            Description = description;
        }

        public Room()
        {
        }

    }
}
