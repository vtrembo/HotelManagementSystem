
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
    public class NavigateProfile : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateProfile(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new ProfileViewModel(_navigationStore);
        }
    }
}
