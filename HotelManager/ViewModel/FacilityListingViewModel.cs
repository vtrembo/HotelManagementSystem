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
    /// FacilityListingViewModel is mapped with FacilityView
    /// </summary>
    public class FacilityListingViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly RoomStore _roomStore;
        private readonly FacilityStore _facilityStore;

        private readonly ObservableCollection<FacilityViewModel> _facilities;

        public IEnumerable<FacilityViewModel> Facilities => _facilities;


        // Stores the value of selected room from RoomView/RoomListingViewModel
        private int _choosenRoom;

        public int ChoosenRoom
        {
            get { return _choosenRoom; }
            set
            {
                _choosenRoom = value;
                OnPropertyChanged();
            }
        }

        // Saves the last selected facility
        private FacilityViewModel _selectedFacility;

        public FacilityViewModel SelectedFacility
        {
            get { return _selectedFacility; }
            set
            {
                if (_selectedFacility != value)
                    _selectedFacility = value;
                OnPropertyChanged();
            }
        }



        public ICommand NavigateProfileCommand { get; }
        public ICommand LoadFacilitiesCommand { get; }
        public ICommand NavigateDamageReportCreationCommand { get; }





        public FacilityListingViewModel(NavigationStore navigationStore, RoomStore roomStore, FacilityStore facilityStore)
        {
            _navigationStore = navigationStore;
            _roomStore = roomStore;
            _facilityStore = facilityStore;
            _facilities = new ObservableCollection<FacilityViewModel>();

            NavigateProfileCommand = new NavigateProfile(_navigationStore);
            LoadFacilitiesCommand = new LoadFacilities(this);
            NavigateDamageReportCreationCommand = new NavigateDamageReportCreation(_navigationStore, this, _facilityStore);

            _roomStore.RoomCreated += OnRoomCreated;        //Sings for RoomCreated event
        }

        private void OnRoomCreated(int roomId)
        {
            ChoosenRoom = roomId;
            LoadFacilitiesCommand.Execute(null);
        }

        public override void Dispose()                      //Disposes the RoomCreated event
        {
            _roomStore.RoomCreated -= OnRoomCreated;

            base.Dispose();
        }

        public static FacilityListingViewModel LoadViewModel(NavigationStore navigationStore, RoomStore roomStore, FacilityStore facilityStore)
        {
            FacilityListingViewModel viewModel = new FacilityListingViewModel(navigationStore, roomStore, facilityStore);

            return viewModel;
        }

        //Loads facilities to the displayble list 
        public void UpdateFacilities(IEnumerable<Facility> facilities)
        {
            _facilities.Clear();

            foreach (Facility facility in facilities)
            {
                FacilityViewModel facilityViewModel = new FacilityViewModel(facility);
                _facilities.Add(facilityViewModel);
            }
        }
    }
}
