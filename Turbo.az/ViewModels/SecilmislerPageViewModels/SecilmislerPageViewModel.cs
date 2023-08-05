using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_Desktop_App.Models;
using Turbo.az_Desktop_App.Views.SelectedVehiclePages;
using Turbo.az_Desktop_App.Views;
using Turbo.az_Desktop_App.Commands;
using System.Windows.Input;

namespace Turbo.az_Desktop_App.ViewModels.SecilmislerPageViewModels
{

    internal class SecilmislerPageViewModel : INotifyPropertyChanged
    {
        private UserModel? _currentUser;
        private string? _secilmislerText;
        private string? _dilText;
        private ObservableCollection<VehicleModel>? favorites;
        private VehicleModel? _selectedVehiclee;

        public ObservableCollection<VehicleModel>? Favorites
        {
            get => favorites;
            set
            {
                favorites = value;
                WhenPropertyChanged();
            }
        }

        public string? secilmislerText
        {
            get => _secilmislerText;
            set
            {
                _secilmislerText = value;
                WhenPropertyChanged();
            }
        }
        public string? dilText
        {
            get => _dilText; set
            {
                _dilText = value;
                WhenPropertyChanged();
            }
        }
        public VehicleModel? selectedVehiclee
        {
            get => _selectedVehiclee; 
            set
            {
                _selectedVehiclee = value;
                WhenPropertyChanged();
            }
        }
        public ICommand? ClickVehicleCommand { get; set; }

        public SecilmislerPageViewModel(UserModel? user, string? diltext)
        {

            _currentUser = user;
            _dilText= diltext;
            Favorites = _currentUser?.Favorites;
            ClickVehicleCommand = new RealCommand(OpenClickVehiclePage);
            if (diltext == "RU")
            {
                secilmislerText = "Seçilmiş Maşınlar";
            }
            else
            {
                secilmislerText = "Рекомендуемые автомобили";
            }
        }


        public void OpenClickVehiclePage(object? parametr)                                           //SELECTED OPEN VEHICLE
        {

            VehicleModel selectedVehicle = _currentUser.returnSelectedVehicle((Guid)parametr!);
            selectedVehiclee = selectedVehicle;
            SelectedVehicleView selected = new(selectedVehiclee, dilText);

            MainwindowView.mainWindowObject!.Mainframe.Content = selected;
        }


        // ->> InotifyFunction <<-- //

        public event PropertyChangedEventHandler? PropertyChanged;

        public void WhenPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
