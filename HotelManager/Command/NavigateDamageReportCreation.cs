using HotelManager.Stores;
using HotelManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HotelManager.Command
{
    public class NavigateDamageReportCreation : CommandBase
    {
        private readonly FacilityListingViewModel _viewModel;
        private readonly NavigationStore _navigationStore;
        private readonly FacilityStore _facilityStore;

        public NavigateDamageReportCreation(NavigationStore navigationStore, FacilityListingViewModel viewModel, FacilityStore facilityStore)
        {
            _navigationStore = navigationStore;
            _facilityStore = facilityStore;
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            if (_viewModel.SelectedFacility == null)
            {
                MessageBox.Show("Please select the facility.", "Error",
                MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            _navigationStore.CurrentViewModel = CreateDamageReportViewModel.LoadViewModel(_navigationStore, _facilityStore);
            _facilityStore.CreateFacility(_viewModel.SelectedFacility.Id);

        }
    }
}
