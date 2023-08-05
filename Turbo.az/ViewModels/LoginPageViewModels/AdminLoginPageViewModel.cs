using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Turbo.az_Desktop_App.Commands;
using Turbo.az_Desktop_App.Views.Pages;
using Turbo.az_Desktop_App.Views;
using Turbo.az_Desktop_App.Database;
using System.Windows;

namespace Turbo.az_Desktop_App.ViewModels.LoginPageViewModels
{
    internal class AdminLoginPageViewModel : INotifyPropertyChanged
    {
        private string? _girisText;
        private string? _gmailText;
        private string? _sifreText;
        private string? _buttonText;
        private string? _adminGmail;
        private string? _adminPassword;

        public string? girisText
        {
            get => _girisText;
            set
            {
                _girisText = value;
                WhenPropertyChanged();
            }
        }

        public string? gmailText
        {
            get => _gmailText;
            set
            {
                _gmailText = value;
                WhenPropertyChanged();
            }
        }


        public string? sifreText
        {
            get => _sifreText;
            set
            {
                _sifreText = value;
                WhenPropertyChanged();
            }
        }

        public string? buttonText
        {
            get => _buttonText;
            set
            {
                _buttonText = value;
                WhenPropertyChanged();
            }
        }


        public string? adminGmail
        {
            get => _adminGmail;
            set
            {
                _adminGmail = value;
                WhenPropertyChanged();
            }
        }

        public string? adminPassword
        {
            get => _adminPassword;
            set
            {
                _adminPassword = value;
                WhenPropertyChanged();
            }
        }

        public string? dilText { get; set; }

        public ICommand? ExitCommand { get; set; }
        public ICommand? GirisCommand { get; set; }



        public AdminLoginPageViewModel(string? diltext)
        {
            dilText = diltext;
            if (diltext == "RU")
            {
                girisText = "Admin hesabına giriş";
                gmailText = "Gmail";
                sifreText = "Şifrə";
                buttonText = "Giriş";
            }
            else if (diltext == "AZ")
            {
                girisText = "Вход в администратора";
                gmailText = "Гмаил";
                sifreText = "Пароль";
                buttonText = "Логин";
            }
            ExitCommand = new RealCommand(ClosePage);
            GirisCommand = new RealCommand(CheckPassword);
        }

        public void ClosePage(object? parametr)
        {
            MainwindowView.mainWindowObject!.AllWindowframe.Content = new EmptyPage();

        }


        public void CheckPassword(object? parametr)
        {
            AdminDatabase adminDB = new();
            bool check = adminDB.CheckAdmin(adminGmail, adminPassword);
            if(check)
            {
                MainwindowView.mainWindowObject!.AllWindowframe.Content = new AdminPage(dilText);

            }    

        }

        // ->> InotifyFunction <<-- //

        public event PropertyChangedEventHandler? PropertyChanged;

        public void WhenPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }



    }
}
