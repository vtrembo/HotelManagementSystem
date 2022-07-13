using HotelManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.ViewModel
{

    /// <summary>
    /// Displaying values of "Facility" ViewModel
    /// </summary>
    public class FacilityViewModel : ViewModelBase
    {
        private readonly Facility _facility;

        public int Id => _facility.IdFacility;
        public string Name => _facility.Name;
        public float Price => _facility.Price;
        public float Weight => _facility.Weight;
        public string Manufacturer => _facility.Manufacturer;
        public string SerialNumber => _facility.SerialNumber;

        public FacilityViewModel(Facility faciliy)
        {
            _facility = faciliy;
        }
    }
}
