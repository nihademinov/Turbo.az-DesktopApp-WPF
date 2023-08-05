using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Turbo.az_Desktop_App.Commands;
using Turbo.az_Desktop_App.Services;
using Turbo.az_Desktop_App.Views;
using Turbo.az_Desktop_App.Views.Pages;
using Turbo.az_Desktop_App.Views.Pages.LoginPage;

namespace Turbo.az_Desktop_App.ViewModels;




internal class SignInPageViewModel : INotifyPropertyChanged
{
    private string? _melumatTextTop;
    private string? _melumatTextBottom;
    private string? _gmailText;
    private string? _adminText;
    private string? _informationBottomText;


    public string? melumatTextTop
    {
        get => _melumatTextTop;
        set

        {
            _melumatTextTop = value;
            WhenPropertyChanged();
        }
    }

    public string? melumatTextBottom
    {
        get => _melumatTextBottom;
        set

        {
            _melumatTextBottom = value;
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



    public string? adminText
    {
        get => _adminText;
        set
        {
            _adminText = value;
            WhenPropertyChanged();
        }
    }

    public string? informationBottomText { 
        get => _informationBottomText;
        set 
        {
            _informationBottomText = value;
            WhenPropertyChanged();
        }
    }


    public ICommand? ExitCommand { get; set; }
    public ICommand? UserCommand { get; set; }
    
    public ICommand? AdminCommand { get; set; }

    public string? DilText { get; set; }


    public SignInPageViewModel(string? diltext)
    {
        DilText = diltext;
        if(diltext=="RU")
        {
            melumatTextTop = "Öz elanlarınıza baxmağın, onları redaktə və";
            melumatTextBottom = "bərpa etməyin rahat yolu";
            gmailText = "Gmail ilə giriş";
           
            adminText = "Admin üçün giriş";
            informationBottomText = "Saytda avtorizasiyadan keçməklə siz Turbo.az-ın İstifadəçi razılaşmasını və Qaydalarını qəbul etdiyinizi təsdiqləmiş olursunuz.";

        }
        else if(diltext=="AZ")
        {
            melumatTextTop = "Удобное редактирование, восстановление";
            melumatTextBottom = "и просмотр своих объявлений";
            gmailText = "Войти через гмаил";
            adminText = "Вход для администратора";
            informationBottomText = "Авторизуясь на сайте, вы подтверждаете согласие с Пользовательским соглашением и Правилами Turbo.az.";
        }


        ExitCommand = new RealCommand(ClosePage);
        UserCommand = new RealCommand(OpenUserLoginPage);
        AdminCommand=new RealCommand(OpenAdminLoginPage);

    }







    public void ClosePage(object? parametr)
    {
        MainwindowView.mainWindowObject!.AllWindowframe.Content = new EmptyPage();        
    }



    public void OpenUserLoginPage(object? parametr)
    {
        MainwindowView.mainWindowObject!.AllWindowframe.Content= new UserLoginPage(DilText);
    }

    public void OpenAdminLoginPage(object? parametr)
    {
        MainwindowView.mainWindowObject!.AllWindowframe.Content = new AdminLoginPage(DilText);
        
    }











    // ->> InotifyFunction <<-- //

    public event PropertyChangedEventHandler? PropertyChanged;

    public void WhenPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

}
