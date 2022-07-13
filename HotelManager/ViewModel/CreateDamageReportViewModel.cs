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
using System.Windows.Input;

namespace HotelManager.ViewModel
{


    /// <summary>
    /// CreateDamageReportViewModel is mapped with CreateDamageReportView
    /// </summary>
    public class CreateDamageReportViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly FacilityStore _facilityStore;


        //Stores the last value entered by user on CreateDamageReportView
        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
        //Stores the value transsfered from FacilityListingViewModel
        private int _choosenFacility;

        public int ChoosenFacility
        {
            get { return _choosenFacility; }
            set
            {
                _choosenFacility = value;
                OnPropertyChanged();
            }
        }




        public ICommand NavigateProfileCommand { get; }
        public ICommand CreateDamageReportCommand { get; }




        public CreateDamageReportViewModel(NavigationStore navigationStore, FacilityStore facilityStore)
        {
            _navigationStore = navigationStore;
            _facilityStore = facilityStore;

            NavigateProfileCommand = new NavigateProfile(_navigationStore);
            CreateDamageReportCommand = new CreateDamageReport(this, _navigationStore);

            _facilityStore.FacilityCreated += OnFacilityCreated;        //Sings for FacilityCreated event
        }

        //Assigns values from FacilityListingViewModel
        private void OnFacilityCreated(int facilityId)
        {
            ChoosenFacility = facilityId;
        }

        public override void Dispose()
        {
            _facilityStore.FacilityCreated -= OnFacilityCreated;        //Disposes the FacilityCreated event

            base.Dispose();
        }

        public static CreateDamageReportViewModel LoadViewModel(NavigationStore navigationStore, FacilityStore facilityStore)
        {
            CreateDamageReportViewModel viewModel = new CreateDamageReportViewModel(navigationStore, facilityStore);

            return viewModel;
        }

       
    }
}
