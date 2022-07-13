using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{
    public class ClientDTO : PersonDTO
    {
        public int IdClient { get; set; }
        public string Email { get; set; }

        public ICollection<RentDTO> Rents { get; set; }
    }
}
