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
using Turbo.az_Desktop_App.ViewModels.AdminPageViewModels;
using Turbo.az_Desktop_App.Views.Pages.AdminPages;
using Turbo.az_Desktop_App.Views.Pages;
using Turbo.az_Desktop_App.Views;
using System.Diagnostics;

namespace Turbo.az_Desktop_App.ViewModels.SelectedVehiclePageViewModels
{
    public class SelectedVehicleViewModel : INotifyPropertyChanged
    {
        private VehicleModel? _selectedVehicle;
        private string? _buttonContent;
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

        public string? dilText
        {
            get => _dilText; set
            {
                _dilText = value;
                WhenPropertyChanged();
            }
        }
        public string? elanIdText
        {
            get => _elanIdText;
            set
            {
                _elanIdText = value;
                WhenPropertyChanged();
            }
        }


        public string? markaText
        {
            get => _markaText;
            set
            {
                _markaText = value;

                WhenPropertyChanged();
            }
        }
        public string? modelText
        {
            get => _modelText;
            set
            {
                _modelText = value;
                WhenPropertyChanged();
            }
        }
        public string? suretlerQutusuText
        {
            get => _suretlerQutusuText;
            set
            {
                _suretlerQutusuText = value;
                WhenPropertyChanged();
            }
        }

        public string? oturucuText
        {
            get => _oturucuText;
            set
            {
                _oturucuText = value;
                WhenPropertyChanged();
            }
        }
        public string? buraxilisIliTexxt
        {
            get => _buraxilisIliTexxt;
            set
            {
                _buraxilisIliTexxt = value;
                WhenPropertyChanged();
            }
        }
        public string? yeniText
        {
            get => _yeniText;
            set
            {
                _yeniText = value;
                WhenPropertyChanged();
            }
        }
        public string? rengText
        {
            get => _rengText;
            set
            {
                _rengText = value;
                WhenPropertyChanged();
            }
        }

        public string? yurusText
        {
            get => _yurusText;
            set
            {
                _yurusText = value;
                WhenPropertyChanged();
            }
        }
        public string? atGucuText
        {
            get => _atGucuText;
            set
            {
                _atGucuText = value;
                WhenPropertyChanged();
            }
        }

        public string? banNovuText
        {
            get => _banNovuText;
            set
            {
                _banNovuText = value;
                WhenPropertyChanged();
            }
        }

        public string? yanacaqNovuText
        {
            get => _yanacaqNovuText;
            set
            {
                _yanacaqNovuText = value;
                WhenPropertyChanged();
            }
        }
        public string? muherrikText
        {
            get => _muherrikText;
            set
            {
                _muherrikText = value;
                WhenPropertyChanged();
            }
        }

        public string? vinKodYoxlanis
        {
            get => _vinKodYoxlanis;
            set
            {
                _vinKodYoxlanis = value;
                WhenPropertyChanged();
            }
        }
        public string? internetdeAxdarText
        {
            get => _internetdeAxdarText;
            set
            {
                _internetdeAxdarText = value;
                WhenPropertyChanged();
            }
        }

        public VehicleModel? SelectedVehicle
        {
            get { return _selectedVehicle; }
            set { _selectedVehicle = value; }
        }

        public ICommand? ClickVehicleCommand { get; set; }
        public ICommand? ReklamCommand { get; set; }
        public ICommand? VINCodeCommand { get; set; }
        public ICommand? ImageButtonClickCommand { get; set; } //Nihad elave

        private string? _selectedImageSource;   // nihad elave
        private string? _markaText;
        private string? _modelText;
        private string? _suretlerQutusuText;
        private string? _oturucuText;
        private string? _buraxilisIliTexxt;
        private string? _yeniText;
        private string? _rengText;
        private string? _yurusText;
        private string? _atGucuText;
        private string? _banNovuText;
        private string? _yanacaqNovuText;
        private string? _muherrikText;
        private string? _vinKodYoxlanis;
        private string? _elanIdText;
        private string? _internetdeAxdarText;
        private string? _dilText;

        public string? SelectedImageSource             // nihad elave    
        {
            get { return _selectedImageSource; }
            set
            {
                if (_selectedImageSource != value)
                {
                    _selectedImageSource = value;
                    WhenPropertyChanged();
                }
            }
        }
        public ICommand? ClickVinButton { get; set; }


        public SelectedVehicleViewModel(VehicleModel selectedVehicle, string? diltext)
        {
            SelectedVehicle = selectedVehicle;
            SelectedImageSource = SelectedVehicle!.photos![0]!.ToString();

            ClickVehicleCommand = new RealCommand(openNumber);
            ImageButtonClickCommand = new RealCommand(OnImageButtonClick);
            ReklamCommand = new RealCommand(OpenReklam);
            ClickVinButton = new RealCommand(searchGoogle);




            dilText = dilText;
            if (diltext == "RU")
            {
                elanIdText = "Elan ID:";
                markaText = "Marka";
                suretlerQutusuText = "Sürətlər qutusu";
                modelText = "Model";
                oturucuText = "Ötürücü";
                buraxilisIliTexxt = "Buraxılış ili";
                yeniText = "Yeni";
                rengText = "Rəng";
                yurusText = "Yürüş";
                atGucuText = "At gücü";
                banNovuText = "Ban növü";
                yanacaqNovuText = "Yanacaq növü";
                muherrikText = "Mühərrik";
                vinKodYoxlanis = "Avtomobili almadan öncə VIN-kodu yoxlayın.";
                internetdeAxdarText = "İnternetdə axtar";
                ButtonContent = "Nömrəni göstər";

            }
            else
            {
                elanIdText = "Номер объявления:";
                markaText = "Марка";
                suretlerQutusuText = "Коробка передач";
                modelText = "Модель";
                oturucuText = "Привод";
                buraxilisIliTexxt = "Год выпуска";
                yeniText = "Новая";
                rengText = "Цвет";
                yurusText = "Пробег";
                atGucuText = "Лошадиные силы";
                banNovuText = "Тип кузова";
                yanacaqNovuText = "Тип топлива";
                muherrikText = "Двигатель";
                vinKodYoxlanis = "Проверяйте VIN-код перед покупкой автомобиля.";
                internetdeAxdarText = "Искать в Интернете";
                ButtonContent = "Показать номер";
            }
        }



        public void OnImageButtonClick(object? parameter)  //nihad elave
        {
            if (parameter is string imagePath)
            {
                SelectedImageSource = imagePath;
            }


        }
        public void searchGoogle(object? parameter)  //nihad elave
        {

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.google.com/search?q=" + Uri.EscapeDataString(SelectedVehicle!.vin!),
                UseShellExecute = true
            };

            Process.Start(psi);

        }


        public void OpenReklam(object? parameter)
        {
            string websiteUrl = "https://www.haval.az/en/Home/model/jolion";

            Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });

        }

        public void OpenChecker(object? parameter)
        {
            string websiteUrl = "https://driving-tests.org/vin-decoder/";

            Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        public void openNumber(object? parametr)
        {
            if (ButtonContent == "Nömrəni göstər" || ButtonContent == "Показать номер")
                ButtonContent = SelectedVehicle!.seller!.phone![0]!;
            else
            {
                if (dilText == "RU")
                    ButtonContent = "Nömrəni göstər";
                else
                    ButtonContent = "Показать номер";
            }

            //TemptNumberButton!.Content = SelectedVehicle!.seller!.phone[0]!;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void WhenPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
