using HotelManager.Command;
using HotelManager.Commands;
using HotelManager.Model;
using HotelManager.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace HotelManager.ViewModel
{

    /// <summary>
    /// ApartmentListingViewModel is mapped with ApartmentView
    /// </summary>
    public class ApartmentListingViewModel : ViewModelBase
    {

        private readonly NavigationStore _navigationStore;
        private readonly ApartmentStore _apartmentStore;

        private readonly ObservableCollection<ApartmentViewModel> _apartments;

        public IEnumerable<ApartmentViewModel> Apartments => _apartments;


        //Stores the last selected apartment by the user on ApartmentView
        private ApartmentViewModel _selectedApartment;

        public ApartmentViewModel SelectedApartment
        {
            get { return _selectedApartment; }
            set 
            {
                if(_selectedApartment != value)
                    _selectedApartment = value;
                OnPropertyChanged();
            }
        }

        public ICommand NavigateProfileCommand { get; }
        public ICommand LoadApartmentsCommand { get; }

        public ICommand NavigateRoomsCommand { get; }

        public ApartmentListingViewModel(NavigationStore navigationStore, ApartmentStore apartmentStore)
        {
            _navigationStore = navigationStore;
            _apartmentStore = apartmentStore;
            _apartments = new ObservableCollection<ApartmentViewModel>();

            NavigateProfileCommand = new NavigateProfile(_navigationStore);
            LoadApartmentsCommand = new LoadApartments(this);
            NavigateRoomsCommand = new NavigateRooms(_navigationStore, this, _apartmentStore);

        }

        public static ApartmentListingViewModel LoadViewModel (NavigationStore navigationStore, ApartmentStore apartmentStore)
        {
            ApartmentListingViewModel viewModel = new ApartmentListingViewModel (navigationStore, apartmentStore);
            viewModel.LoadApartmentsCommand.Execute(null);

            return viewModel;
        }
        public void UpdateApartments(IEnumerable<Apartment> apartments)
        {
            _apartments.Clear();

            foreach (Apartment apartment in apartments)
            {
                ApartmentViewModel apartmentViewModel = new ApartmentViewModel(apartment);
                _apartments.Add(apartmentViewModel);
            }
        }
    }
}

