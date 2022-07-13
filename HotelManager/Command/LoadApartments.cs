using HotelManager.DbContexts;
using HotelManager.Model;
using HotelManager.Services;
using HotelManager.Services.ApartmentProvider;
using HotelManager.ViewModel;
using HotelManager.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HotelManager.Command
{
    public class LoadApartments : AsyncCommandBase
    {

        private readonly ApartmentListingViewModel _viewModel;

        public LoadApartments(ApartmentListingViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override async Task ExecuteAsync(object parameter)
        {

            try
         
            {
                HotelDbContextFactory hotelDbContextfactory = new HotelDbContextFactory("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\sweaz\\Desktop\\HotelManager\\HotelDb.mdf");
                IApartmentProvider apartmentProvider = new DatabaseApartmentProvider(hotelDbContextfactory);
                IEnumerable<Apartment> apartments = await apartmentProvider.GetAllApartments();
                _viewModel.UpdateApartments(apartments);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to load apartments.","Error", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
