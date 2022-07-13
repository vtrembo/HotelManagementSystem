using HotelManager.DbContexts;
using HotelManager.Model;
using HotelManager.ViewModel;
using HotelManager.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using HotelManager.Services.RoomProvider;

namespace HotelManager.Command
{
    public class LoadRooms : AsyncCommandBase
    {

        private readonly RoomListingViewModel _viewModel;

        public LoadRooms(RoomListingViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            try
            {
                HotelDbContextFactory hotelDbContextfactory = new HotelDbContextFactory("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\sweaz\\Desktop\\HotelManager\\HotelDb.mdf");
                IRoomProvider roomProvider = new DatabaseRoomProvider(hotelDbContextfactory);
                IEnumerable<Room> rooms = await roomProvider.GetAllRoomsFrom(_viewModel.ChoosenApartment);
                _viewModel.UpdateRooms(rooms);
            }
            catch (Exception)
            {
                    MessageBox.Show("Failed to load rooms.", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
