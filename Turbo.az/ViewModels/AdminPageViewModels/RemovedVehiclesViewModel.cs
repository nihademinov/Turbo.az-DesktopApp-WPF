using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Turbo.az_Desktop_App.Commands;
using Turbo.az_Desktop_App.Database;
using Turbo.az_Desktop_App.Models;
using Turbo.az_Desktop_App.Views.Pages.AdminPages;
using Turbo.az_Desktop_App.Views.Pages;
using Turbo.az_Desktop_App.Views;
using Turbo.az_Desktop_App.ViewModels.SelectedVehiclePageViewModels;
using Turbo.az_Desktop_App.Views.SelectedVehiclePages;

namespace Turbo.az_Desktop_App.ViewModels.AdminPageViewModels
{
    class RemovedVehiclesViewModel
    {

        public CarsDatabase _VehiclesDb = new CarsDatabase(true);
        public string? dilText { get; set; }
        public CarsDatabase VehiclesDb
        {
            get { return _VehiclesDb = new CarsDatabase(true); }
            set
            {
                _VehiclesDb = value;
                WhenPropertyChanged();
            }
        }

        public ICommand? BackCommand { get; set; }

        public ICommand? ClickVehicleCommand { get; set; }
        public RemovedVehiclesViewModel(string? diltext)
        {
            dilText = diltext;
            ClickVehicleCommand = new RealCommand(OpenClickVehiclePage);
            BackCommand = new RealCommand(BackAdminpage);
        }


        public void OpenClickVehiclePage(object? parametr) //SELECTED OPEN VEHICLE
        {
            VehicleModel selectedVehicle = VehiclesDb.returnRemovedVehicle((Guid)parametr!);
            SelectedVehicleView selected = new(selectedVehicle,"RU");
            

            MainwindowView.mainWindowObject!.AllWindowframe.Content = selected;
        }


        public void BackAdminpage(object? parametr)
        {
            MainwindowView.mainWindowObject!.AllWindowframe.Content = new AdminPage(dilText);
        }


        // ->> InotifyFunction <<-- //

        public event PropertyChangedEventHandler? PropertyChanged;

        public void WhenPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
