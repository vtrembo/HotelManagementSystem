using HotelManager.Command;
using HotelManager.Commands;
using HotelManager.Model;
using HotelManager.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotelManager.ViewModel
{


    /// <summary>
    /// RoomListingViewModel is mapped with RoomView
    /// </summary>
    public class RoomListingViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly ApartmentStore _apartmentStore;
        private readonly RoomStore _roomStore;

        private readonly ObservableCollection<RoomViewModel> _rooms;

        public IEnumerable<RoomViewModel> Rooms => _rooms;


        //Stores the selected apartment on ApartmentView by the user
        private int _choosenApartment;

        public int ChoosenApartment
        {
            get { return _choosenApartment; }
            set 
            {
                _choosenApartment = value;
                OnPropertyChanged();
            }
        }


        //Stores the last selected value from RoomViewModel
        private RoomViewModel _selectedRoom;

        public RoomViewModel SelectedRoom
        {
            get { return _selectedRoom; }
            set
            {
                if (_selectedRoom != value)
                    _selectedRoom = value;
                OnPropertyChanged();
            }
        }



        public ICommand NavigateProfileCommand { get; }
        public ICommand NavigateFacilityCommand { get; }
        public ICommand LoadRoomsCommand { get; }




        public RoomListingViewModel(NavigationStore navigationStore, ApartmentStore apartmentStore, RoomStore roomStore)
        {
            _navigationStore = navigationStore;
            _apartmentStore = apartmentStore;
            _roomStore = roomStore;
            _rooms = new ObservableCollection<RoomViewModel>();

            NavigateProfileCommand = new NavigateProfile(_navigationStore);
            NavigateFacilityCommand = new NavigateFacilities(_navigationStore, this, _roomStore);
            LoadRoomsCommand = new LoadRooms(this);

            _apartmentStore.ApartmentCreated += OnApartmentCreated;     //Sings for ApartmentCreated event
        }

        private void OnApartmentCreated(int apartmentNumber)
        {
            ChoosenApartment = apartmentNumber;
            LoadRoomsCommand.Execute(null);
        }

        public override void Dispose()
        {
            _apartmentStore.ApartmentCreated -= OnApartmentCreated;     //Disposes the ApartmentCreated event

            base.Dispose();
        }

        public static RoomListingViewModel LoadViewModel(NavigationStore navigationStore, ApartmentStore apartmentStore, RoomStore roomStore)
        {
            RoomListingViewModel viewModel = new RoomListingViewModel(navigationStore, apartmentStore, roomStore);
            
            return viewModel;
        }

        public void UpdateRooms(IEnumerable<Room> rooms)
        {
            _rooms.Clear();

            foreach (Room room in rooms)
            {
                RoomViewModel roomViewModel = new RoomViewModel(room);
                _rooms.Add(roomViewModel);
            }
        }
    }
}
