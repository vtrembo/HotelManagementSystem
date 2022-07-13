using HotelManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Services.ApartmentProvider
{
    public interface IApartmentProvider
    {
        Task<IEnumerable<Apartment>> GetAllApartments();
    }
}
