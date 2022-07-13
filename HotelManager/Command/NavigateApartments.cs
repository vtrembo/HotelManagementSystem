
using HotelManager.Services;
using HotelManager.Command;
using HotelManager.ViewModel;
using HotelManager.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Commands
{
    public class NavigateApartments : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateApartments(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            ApartmentStore apartmentStore = new ApartmentStore();
            _navigationStore.CurrentViewModel = ApartmentListingViewModel.LoadViewModel(_navigationStore, apartmentStore);
        }
    }
}
