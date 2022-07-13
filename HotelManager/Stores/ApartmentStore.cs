using HotelManager.Model;
using HotelManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Stores
{
    public class ApartmentStore
    {
        public event Action<int> ApartmentCreated;
        public void CreateApartment(int apartmentNumber)
        {
            ApartmentCreated?.Invoke(apartmentNumber);
        }
    }
}
