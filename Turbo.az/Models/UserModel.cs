using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Turbo.az_Desktop_App.Models;

public class UserModel : INotifyPropertyChanged
{
    //--------------------------private variables---------------------------

    private string? _gmail;  // User Gmail

    private Guid _id = Guid.NewGuid(); // User Id

    // Favoite Car`s 
    private ObservableCollection<VehicleModel>? favorites;


    //-------------------------public properties----------------------------- 
    public Guid Id
    {
        get => _id;
        set
        {
            _id = value;
            WhenPropertyChanged();
        }
    }

    public string? Gmail
    {
        get => _gmail;
        set
        {
            _gmail = value;
            WhenPropertyChanged();
        }
    }

    public ObservableCollection<VehicleModel>? Favorites
    {
        get => favorites; 
        set
        {
            favorites = value;
            WhenPropertyChanged();
        }
    }

    //------------------------------------------------------------------------------


    public VehicleModel returnSelectedVehicle(Guid id)
    {
        if (favorites != null)
        {
            foreach (var item in favorites)
            {
                if (item!.carId == id)
                {
                    return item;
                }
            }

        }
        return null!;
    }

    // ->> InotifyFunction <<-- //

    public event PropertyChangedEventHandler? PropertyChanged;

    public void WhenPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

}
