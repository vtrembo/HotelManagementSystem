using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManager.Stores;
using HotelManager.ViewModel;
using System.Windows;


namespace HotelManager.Command
{
    public class NavigateFacilities : CommandBase
    {

        private readonly RoomListingViewModel _viewModel;
        private readonly NavigationStore _navigationStore;
        private readonly RoomStore _roomStore;

        public NavigateFacilities(NavigationStore navigationStore, RoomListingViewModel viewModel, RoomStore roomStore)
        {
            _navigationStore = navigationStore;
            _roomStore = roomStore;
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            if (_viewModel.SelectedRoom == null)
            {
                MessageBox.Show("Please select the room.", "Error",
                MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            FacilityStore facilityStore = new FacilityStore();
            _navigationStore.CurrentViewModel = FacilityListingViewModel.LoadViewModel(_navigationStore, _roomStore, facilityStore);
            _roomStore.CreateRoom(_viewModel.SelectedRoom.Id);

        }
    }
}
