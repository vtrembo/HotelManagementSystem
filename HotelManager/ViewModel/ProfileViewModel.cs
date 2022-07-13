using HotelManager.Command;
using HotelManager.Commands;
using HotelManager.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotelManager.ViewModel
{

    /// <summary>
    /// ProfileViewModel is mapped with ProfileView
    /// </summary>
    public class ProfileViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        public ICommand NavigateApartmentsCommand { get; }


        public ProfileViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            NavigateApartmentsCommand = new NavigateApartments(_navigationStore);
        }

    }
}
