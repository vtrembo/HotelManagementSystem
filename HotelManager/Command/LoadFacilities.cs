using HotelManager.DbContexts;
using HotelManager.DTO;
using HotelManager.Model;
using HotelManager.Services.ApartmentProvider;
using HotelManager.ViewModel;
using HotelManager.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using HotelManager.Services.FacilityProvider;

namespace HotelManager.Command
{
    public class LoadFacilities : AsyncCommandBase
    {
        private readonly FacilityListingViewModel _viewModel;

        public LoadFacilities(FacilityListingViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            try
            {
                HotelDbContextFactory hotelDbContextfactory = new HotelDbContextFactory("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\sweaz\\Desktop\\HotelManager\\HotelDb.mdf");
                IFacilityProvider facilityProvider = new DatabaseFacilityProvider(hotelDbContextfactory);
                IEnumerable<Facility> facilities = await facilityProvider.GetAllFacilitiesFromRoom(_viewModel.ChoosenRoom);
                _viewModel.UpdateFacilities(facilities);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to load rooms.", "Error",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }


    }
}
