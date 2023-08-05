using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using Turbo.az_Desktop_App.Commands;
using Turbo.az_Desktop_App.Database;
using Turbo.az_Desktop_App.Models;
using Turbo.az_Desktop_App.Services;
using Turbo.az_Desktop_App.Views;
using Turbo.az_Desktop_App.Views.Pages;
using Turbo.az_Desktop_App.Views.Pages.LoginPage;

namespace Turbo.az_Desktop_App.ViewModels.LoginPageViewModels
{
    internal class UserVerificationLoginPageViewModel : INotifyPropertyChanged
    {
        private string? _girisText;
        private string? _informationText;
        private string? _kesikGmail = "";
        private string? _kodText;
        private string? _buttonText;
        private string? _verificationText;
        private string? _sendedCode;
        private string? _enableText;
        private readonly DispatcherTimer? _timer;
        public string? girisText
        {
            get => _girisText;
            set
            {
                _girisText = value;
                WhenPropertyChanged();
            }
        }


        public string? informationText
        {
            get => _informationText;
            set
            {
                _informationText = value;
                WhenPropertyChanged();
            }
        }

        public string? kesikGmail
        {
            get => _kesikGmail;
            set
            {
                _kesikGmail = value;
                WhenPropertyChanged();
            }
        }

        public string? kodText
        {
            get => _kodText;
            set
            {
                _kodText = value;
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

        public string? verificationText
        {
            get => _verificationText;
            set
            {
                _verificationText = value;
                WhenPropertyChanged();
            }
        }
        public string? sendedCode
        {
            get => _sendedCode;
            set
            {
                _sendedCode = value;
                WhenPropertyChanged();
            }
        }

        public string? enableText
        {
            get => _enableText;
            set
            {
                _enableText = value;
                WhenPropertyChanged();
            }
        }




        public string? gmail { get; set; }

        public string? dilText { get; set; }

        public ICommand? BackCommand { get; set; }
        public ICommand? VerifiyCommand { get; set; }
        public UserVerificationLoginPageViewModel(string? diltext, string? gmail)
        {
            enableText = "true";

            this.gmail = gmail;
            _timer = new DispatcherTimer();
            dilText = diltext;
            BackCommand = new RealCommand(BackUserLoginPage);
            VerifiyCommand = new RealCommand(CheckVerificationCode);
            int indexOfAtSign = gmail!.IndexOf('@');
            if (indexOfAtSign >= 0)
            { kesikGmail = gmail.Substring(0, indexOfAtSign); }


            if (diltext == "RU")
            {
                girisText = "Gmailin təsdiqlənməsi";
                informationText = $"{kesikGmail} adresinə kod göndərildi";
                kodText = "Təsdiq kodu";
                buttonText = "Təsdiqlə";
                _verificationText = "";
            }
            else if (diltext == "AZ")
            {
                girisText = "Проверка Гмаил";
                informationText = $"код был отправлен на {kesikGmail}";
                kodText = "Проверочный код";
                buttonText = "Подтверждать";
                _verificationText = "";
            }
            Thread thread1 = new Thread(SendFnuction);
            thread1.Start();
        }

        public void BackUserLoginPage(object? parametr)
        {
            MainwindowView.mainWindowObject!.AllWindowframe.Content = new UserLoginPage(dilText);

        }


        public void CheckVerificationCode(object? parametr)
        {
            if (verificationText == sendedCode)
            {
                UserDatabase userDB = new UserDatabase();
                bool check = userDB.FindUser(gmail);
                if(check)
                {
                    UserModel currentUser = userDB.ReturnUser(gmail);
                    JsonSerializerOptions op = new JsonSerializerOptions();
                    op.WriteIndented = true;
                    File.WriteAllText("currentUser.json", JsonSerializer.Serialize(currentUser, op));
                }
                else
                {
                    UserModel newUser = new UserModel() { Gmail = gmail};
                    userDB.AddUser(newUser);
                    JsonSerializerOptions op = new JsonSerializerOptions();
                    op.WriteIndented = true;
                    File.WriteAllText("currentUser.json", JsonSerializer.Serialize(newUser, op));
                }
                
                MainwindowView.mainWindowObject!.AllWindowframe.Content = new EmptyPage();
            }
            else
            {
                
                enableText = "false";

                _timer.Interval = TimeSpan.FromSeconds(30);
                _timer.Tick += ButtonEnable;
                _timer.Start();
            }
        }

        private void ButtonEnable(object? sender, EventArgs e)
        {
            enableText = "true";
        }

        public void SendFnuction()
        {
            VerificationService verifiy = new VerificationService(gmail);
            sendedCode = verifiy.verification;
        }


        // ->> InotifyFunction <<-- //

        public event PropertyChangedEventHandler? PropertyChanged;

        public void WhenPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
