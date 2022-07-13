using HotelManager.DbContexts;
using HotelManager.Services.ApartmentProvider;
using HotelManager.Services.DamageReportCreator;
using HotelManager.Services.FacilityProvider;
using HotelManager.Services.RoomProvider;
using HotelManager.Stores;
using HotelManager.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HotelManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost _host;


        /// <summary>
        /// Initializing host services
        /// </summary>
        public App()
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
            {
                services.AddSingleton(new HotelDbContextFactory(hostContext.Configuration.GetConnectionString("Default")));
                services.AddSingleton<IApartmentProvider, DatabaseApartmentProvider>();
                services.AddSingleton<IRoomProvider, DatabaseRoomProvider>();
                services.AddSingleton<IFacilityProvider, DatabaseFacilityProvider>();
                services.AddSingleton<IDamageReportCreator, DatabaseDamageReportCreator>();

                services.AddSingleton<NavigationStore>();

                services.AddSingleton<MainViewModel>();
                services.AddSingleton(s => new MainWindow()
                {
                    DataContext = s.GetRequiredService<MainViewModel>()
                });

            }).Build();
        }

        protected override void OnStartup(StartupEventArgs e)
        {

            //   DbContextOptions options = new DbContextOptionsBuilder().UseSqlite("Data Source = hoteldb.db").Options;

            _host.Start();
            HotelDbContextFactory hotelDbContextFactory = _host.Services.GetRequiredService<HotelDbContextFactory>();
            using (HotelDbContext hotelDbContext = hotelDbContextFactory.CreateDbContext())
            {
                hotelDbContext.Database.Migrate();
            }
            NavigationStore navigationStore = _host.Services.GetRequiredService<NavigationStore>();
            navigationStore.CurrentViewModel = new ProfileViewModel(navigationStore);
            MainWindow = _host.Services.GetRequiredService<MainWindow>();
            MainWindow.Show();


            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _host.Dispose();

            base.OnExit(e);
        }

    }
}
