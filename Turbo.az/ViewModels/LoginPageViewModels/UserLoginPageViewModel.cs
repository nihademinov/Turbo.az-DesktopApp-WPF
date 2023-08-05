using System.Windows.Input;
using Turbo.az_Desktop_App.Views.Pages;
using Turbo.az_Desktop_App.Views;
using Turbo.az_Desktop_App.Commands;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Turbo.az_Desktop_App.Views.Pages.LoginPage;
using System.Linq;
using System;
using System.Text.RegularExpressions;



namespace Turbo.az_Desktop_App.ViewModels.LoginPageViewModels;

internal class UserLoginPageViewModel : INotifyPropertyChanged
{
    private string? _gmailText;
    private string? _buttonText;
    private string? _girisText;
    private string? _gmail;
    private string? _textboxColor;

    public string? girisText
    {
        get => _girisText;
        set
        {
            _girisText = value;
            WhenPropertyChanged();
        }
    }

    public string? gmail
    {
        get => _gmail;
        set
        {
            _gmail = value;
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


    public string? buttonText
    {
        get => _buttonText;
        set
        {
            _buttonText = value;
            WhenPropertyChanged();
        }
    }


    public string? textboxColor
    {
        get => _textboxColor;
        set
        {
            _textboxColor = value;
            WhenPropertyChanged();
        }
    }

    public string? dilText { get; set; }




    public ICommand? ExitCommand { get; set; }
    public ICommand? OpenVerificationPageCommand { get; set; }

    public UserLoginPageViewModel(string? diltext)
    {
        dilText = diltext;
        textboxColor = "Black";
        gmail = "";
        if (diltext == "RU")
        {
            gmailText = "Gmail";
            buttonText = "Təsdiq kodunu göndərin";
            girisText = "Kabinetə giriş";
        }
        else if (diltext == "AZ")
        {
            gmailText = "Гмаил";
            buttonText = "Отправить код подтверждения";
            girisText = "Вход в кабинет";
        }



        ExitCommand = new RealCommand(ClosePage);
        OpenVerificationPageCommand = new RealCommand(OpenVerificationPage);

    }


    public void ClosePage(object? parametr)
    {
        MainwindowView.mainWindowObject!.AllWindowframe.Content = new EmptyPage();
        


    }

    public void OpenVerificationPage(object? parametr)
    {
        string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
        bool check = Regex.IsMatch(gmail, pattern);

        if (check)
        {
            MainwindowView.mainWindowObject!.AllWindowframe.Content = new UserVerificationPage(dilText, gmail);
        }
        else
        {
            textboxColor = "DarkRed";
        }
    }



    // ->> InotifyFunction <<-- //

    public event PropertyChangedEventHandler? PropertyChanged;

    public void WhenPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
