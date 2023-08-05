using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Turbo.az_Desktop_App.Models;


public class AdminModel : INotifyPropertyChanged
{
    //------------------private variables-------------------

    private Guid _idAdmin =  Guid.NewGuid(); // Admin Id

    private string? _password; // Admin Password

    private string? _gmail;  // Admin Gmail

    //-----------------public properties--------------------
    public Guid idAdmin
    {
        get => _idAdmin;
        set
        {
            _idAdmin = value;
            WhenPropertyChanged();
        }
    }

    public string? password
    {
        get => _password;
        set
        {
            _password = value;
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

    // ->> InotifyFunction <<-- //

    public event PropertyChangedEventHandler? PropertyChanged;

    public void WhenPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
