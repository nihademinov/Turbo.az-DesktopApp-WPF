using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml;
using Turbo.az_Desktop_App.Commands;
using Turbo.az_Desktop_App.Database;
using Turbo.az_Desktop_App.Models;
using Turbo.az_Desktop_App.Views.Pages.AdminPages;
using Turbo.az_Desktop_App.Views;

namespace Turbo.az_Desktop_App.ViewModels.AdminPageViewModels
{
    class SelectedWaitingViewModel : INotifyPropertyChanged
    {



        private VehicleModel? _selectedVehicle;
        private string? _buttonContent = "Tesdiqle";
        public ICommand? TestiqleCommand { get; set; }
        public ICommand? ImtinaCommand { get; set; }
        public CarsDatabase vehicleDb
        {
            get => _vehicleDb;
            set
            {
                _vehicleDb = value;
                WhenPropertyChanged();
            }
        }


        public string? ButtonContent
        {
            get { return _buttonContent; }
            set
            {
                if (_buttonContent != value)
                {
                    _buttonContent = value;
                    WhenPropertyChanged();
                }
            }
        }

        private string? _buttonContentImtina = "Imtina";
        private CarsDatabase _vehicleDb=new CarsDatabase(true);

        public string? ButtonContentImtina
        {
            get { return _buttonContentImtina; }
            set
            {
                if (_buttonContentImtina != value)
                {
                    _buttonContentImtina = value;
                    WhenPropertyChanged();
                }
            }
        }





        public VehicleModel? SelectedVehicle
        {
            get { return _selectedVehicle; }
            set { _selectedVehicle = value; }
        }

        public SelectedWaitingViewModel(VehicleModel selectedVehicle)
        {
            SelectedVehicle = selectedVehicle;
            TestiqleCommand = new RealCommand(SubmitVehicle);
            ImtinaCommand = new RealCommand(DeleteVehicle);

        }

        public void SubmitVehicle(object? parametr)
        {
            vehicleDb.Submit(SelectedVehicle!.carId);
            MainwindowView.mainWindowObject!.AllWindowframe.Content = new WaitingVehiclePage("RU");
        }

        public void DeleteVehicle(object? parametr)
        {
            vehicleDb.RemoveWaitingVehicle(SelectedVehicle!.carId);
            MainwindowView.mainWindowObject!.AllWindowframe.Content = new WaitingVehiclePage("RU");
        }




        public event PropertyChangedEventHandler? PropertyChanged;



        public void WhenPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
