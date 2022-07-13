using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{
    public class TableDTO
    {
        public int Number { get; set; }
        public int NumberOfSeats { get; set; }
        public bool IsIndoor { get; set; }
        public bool? _IsInSmokingAre { get; set; }
        public bool? IsInSmokingAre
        {
            get
            {
                if (!IsIndoor)
                {
                    throw new Exception("Table is not indoor");
                }

                return _IsInSmokingAre;
            }
            set
            {
                if (!IsIndoor)
                {
                    throw new Exception("Table is not indoor");
                }

                _IsInSmokingAre = value;
            }
        }
        public bool IsOutdoor { get; set; }
        public bool? _HasUmbrella { get; set; }
        public bool? HasUmbrella
        {
            get
            {
                if (!IsOutdoor)
                {
                    throw new Exception("Table is not outside");
                }

                return _HasUmbrella;
            }
            set
            {
                if (!IsOutdoor)
                {
                    throw new Exception("Table is not outside");
                }

                _HasUmbrella = value;
            }
        }
        public int IdRestaurant { get; set; }
        public RestaurantDTO Restaurant { get; set; }

        public ReservationDTO Reservation { get; set; }



    }
}
