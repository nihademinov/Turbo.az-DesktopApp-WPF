using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_Desktop_App.Views.Pages;
using Turbo.az_Desktop_App.Views;
using System.Windows.Input;
using Turbo.az_Desktop_App.Commands;
using Turbo.az_Desktop_App.Views.Pages.AdminPages;

namespace Turbo.az_Desktop_App.ViewModels
{
    internal class AdminPageViewModel : INotifyPropertyChanged
    {
        private string? _waitingVehicleText;
        private string? _removedVehicleText;

        public string? waitingVehicleText
        {
            get => _waitingVehicleText;
            set
            {
                _waitingVehicleText = value;
                WhenPropertyChanged();
            }
        }

        public string? dilText { get; set; }

        public string? removedVehicleText
        {
            get => _removedVehicleText;
            set
            {
                _removedVehicleText = value;
                WhenPropertyChanged();
            }
        }


        public ICommand? ExitCommand { get; set; }
        public ICommand? WaitingVehicleCommand { get; set; }
        public ICommand? RemovedVehicleCommand { get; set; }

        public AdminPageViewModel(string? diltext)
        {
            dilText = diltext;
            if (diltext == "RU")
            {
                waitingVehicleText = "Gözləyən Elanlar";
                removedVehicleText = "Silinən Elanlar";
            }
            else
            {
                waitingVehicleText = "Ожидающие объявления";
                removedVehicleText = "Удаленные объявления";
            }

            ExitCommand = new RealCommand(ClosePage);
            WaitingVehicleCommand = new RealCommand(OpenWaitingVehiclepage);
            RemovedVehicleCommand = new RealCommand(OpenRemovedVehiclepage);
        }

        public void ClosePage(object? parametr)
        {
            MainwindowView.mainWindowObject!.AllWindowframe.Content = new EmptyPage();

        }
        public void OpenWaitingVehiclepage(object? parametr)
        {
            MainwindowView.mainWindowObject!.AllWindowframe.Content = new WaitingVehiclePage(dilText);
        }
        public void OpenRemovedVehiclepage(object? parametr)
        {
            MainwindowView.mainWindowObject!.AllWindowframe.Content = new RemovedVehiclesView(dilText);
        }

        // ->> InotifyFunction <<-- //

        public event PropertyChangedEventHandler? PropertyChanged;

        public void WhenPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
