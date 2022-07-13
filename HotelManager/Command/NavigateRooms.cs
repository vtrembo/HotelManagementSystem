using HotelManager.Model;
using HotelManager.Stores;
using HotelManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HotelManager.Command
{
    public class NavigateRooms : CommandBase
    {

        private readonly ApartmentListingViewModel _viewModel;
        private readonly NavigationStore _navigationStore;
        private readonly ApartmentStore _apartmentStore;

        public NavigateRooms(NavigationStore navigationStore, ApartmentListingViewModel viewModel, ApartmentStore apartmentStore)
        {
            _navigationStore = navigationStore;
            _apartmentStore = apartmentStore;
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            
            if(_viewModel.SelectedApartment == null)
            {
                MessageBox.Show("Please select the apartment.", "Error",
                MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            RoomStore roomStore = new RoomStore();
            _navigationStore.CurrentViewModel = RoomListingViewModel.LoadViewModel(_navigationStore, _apartmentStore, roomStore);
            _apartmentStore.CreateApartment(_viewModel.SelectedApartment.Number);


        }
    }
}
