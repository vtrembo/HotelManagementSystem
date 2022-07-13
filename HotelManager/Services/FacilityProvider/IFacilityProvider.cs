using HotelManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Services.FacilityProvider
{
    public interface IFacilityProvider
    {
        Task<IEnumerable<Facility>> GetAllFacilitiesFromRoom(int roomId);
    }
}
