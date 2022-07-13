using HotelManager.Commands;
using HotelManager.DbContexts;
using HotelManager.Model;
using HotelManager.Services.DamageReportCreator;
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
    public class CreateDamageReport : AsyncCommandBase
    {
        private readonly CreateDamageReportViewModel _viewModel;
        private readonly NavigationStore _navigationStore;

        public CreateDamageReport(CreateDamageReportViewModel viewModel, NavigationStore navigationStore)
        {
            _viewModel = viewModel;
            _navigationStore = navigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {

            if (_viewModel.Description == null)
            {
                MessageBox.Show("Please provide the description.", "Error",
                MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                DamageReport damageReport = new DamageReport(_viewModel.Description, _viewModel.ChoosenFacility);
                HotelDbContextFactory hotelDbContextfactory = new HotelDbContextFactory("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\sweaz\\Desktop\\HotelManager\\HotelDb.mdf");
                IDamageReportCreator damageReportCreator = new DatabaseDamageReportCreator(hotelDbContextfactory);
                await damageReportCreator.CreateDamageReport(damageReport);
                _navigationStore.CurrentViewModel = new ProfileViewModel(_navigationStore);

                MessageBox.Show("Damage report is successfully created", "Success",
                MessageBoxButton.OK, MessageBoxImage.None);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to create damage report.", "Error",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
