using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Turbo.az_Desktop_App.ViewModels.SecilmislerPageViewModels;

public class SecilmislerErrorPageViewModel : INotifyPropertyChanged
{
    private string? _messageTop;
    private string? _messageBottom;

    public string? messageTop
    {
        get => _messageTop;
        set
        {
            _messageTop = value;
            WhenPropertyChanged();
        }
    }

    public string? messageBottom
    {
        get => _messageBottom;
        set
        {
            _messageBottom = value;
            WhenPropertyChanged();
        }
    }

    public SecilmislerErrorPageViewModel(string? diltext)
    {
        if(diltext=="RU")
        {
            messageTop = "Seçilmişlər bölməsini aktiv etmək üçün";
            messageBottom = "əvvəlcə hesaba daxil olun və ya qeydiyyatdan keçin.";
        }
        else if(diltext=="AZ")
        {
            messageTop = "Чтобы включить раздел Избранное";
            messageBottom = "сначала войдите или зарегистрируйте учетную запись.";
        }
    }




    // ->> InotifyFunction <<-- //

    public event PropertyChangedEventHandler? PropertyChanged;

    public void WhenPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
