using HotelManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.ViewModel
{

    /// <summary>
    /// Displaying values of "Apartment" ViewModel
    /// </summary>
    public class ApartmentViewModel : ViewModelBase
    {
        private readonly Apartment _apartment;

        public int Number => _apartment.Number;
        public int NumberOfBeds => _apartment.NumberOfBeds;
        public float Area => _apartment.Area;
        public string Description => _apartment.Description;

        public ApartmentViewModel(Apartment apartment)
        {
            _apartment = apartment;
        }
    }
}
