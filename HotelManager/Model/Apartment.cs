using HotelManager.Services.ApartmentProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Model
{
    public enum ApartmentType
    {
        Regular,
        VIP,
        Family,
        Penthouse
    }
    public class Apartment
    {

        private readonly IApartmentProvider _apartmentProvider;

        private int _number;

        public int Number
        {
            get { return _number; }
            set
            {
                if (value.Equals(null)) throw new ArgumentNullException(nameof(value));
                _number = value;
            }
        }
        private int _numberOfBeds;
        public int NumberOfBeds
        {
            get { return _numberOfBeds; }
            set
            {
                if (value.Equals(null)) throw new ArgumentNullException(nameof(value));
                _numberOfBeds = value;
            }
        }
        private float _area;

        public float Area
        {
            get { return _area; }
            set
            {
                if (value.Equals(null)) throw new ArgumentNullException(nameof(value));
                _area = value;
            }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException(nameof(value));
                _description = value;
            }
        }
        private List<ApartmentType> _apartmentTypes = new List<ApartmentType> { };

        public List<ApartmentType> ApartmentTypes
        {
            get { return new List<ApartmentType>(_apartmentTypes); }
            set
            {
                if (value.Equals(null)) throw new ArgumentNullException(nameof(value));
                _apartmentTypes = value;
            }
        }

        public int? _AmountOfDrinks { get; set; }

        public int? AmountOfDrinks
        {
            get
            {
                if (!ApartmentTypes.Contains(ApartmentType.VIP))
                    throw new Exception("The appartment is not classified as \"VIP\"");
                return _AmountOfDrinks;
            }
            set
            {
                if (!ApartmentTypes.Contains(ApartmentType.VIP))
                    throw new Exception("The appartment is not classified as \"VIP\"");
                _AmountOfDrinks = value;
            }
        }

        public int? _NumberOfChildenBeds { get; set; }
        public int? NumberOfChildenBeds
        {
            get
            {
                if (!ApartmentTypes.Contains(ApartmentType.Family))
                    throw new Exception("The appartment is not classified as \"Family\"");
                return _NumberOfChildenBeds;
            }
            set
            {
                if (!ApartmentTypes.Contains(ApartmentType.Family))
                    throw new Exception("The appartment is not classified as \"Family\"");
                _NumberOfChildenBeds = value;
            }
        }
        public bool? _HasRoofZone { get; set; }

        public bool? HasRoofZone
        {
            get
            {
                if (!ApartmentTypes.Contains(ApartmentType.Penthouse))
                    throw new Exception("The appartment is not classified as \"Penthouse\"");
                return _HasRoofZone;
            }
            set
            {
                if (!ApartmentTypes.Contains(ApartmentType.Penthouse))
                    throw new Exception("The appartment is not classified as \"Penthouse\"");
                _HasRoofZone = value;
            }
        }
        public Apartment(int number, int numberOfBeds, float area, string description)
        {
            Number = number;
            NumberOfBeds = numberOfBeds;
            Area = area;
            Description = description;
        }

        public Apartment()
        {
        }
    }
}
