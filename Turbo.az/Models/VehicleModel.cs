using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;



namespace Turbo.az_Desktop_App.Models;
public class VehicleModel : INotifyPropertyChanged
{
    //---------------------------------Private Variables---------------------------------
    private Guid _carId = Guid.NewGuid();
    private List<string?>? _attributes = new List<string?>();
    private string? _year;
    private string? _category;
    private string? _maker;
    private string? _model;
    private string? _color;
    private string? _power;
    private string? _petroleum;
    private string? _mileage;
    private string? _gear;
    private string? _newCar;
    private string? _price;
    private string? _vin;
    private string? _additional;
    private Seller? _seller;
    private string? _engineVolume;
    private string? _transmission;
    private List<string?>? _photos;
    private string? _place= "Bakı";

    public VehicleModel(List<string?>? attributes, string? year, string? category, string? maker, string? model, string? color, string? power, string? petroleum, string? mileage, string? gear, string? newCar, string? price, string? vin, string? additional, Seller? seller, string? engineVolume, string? transmission, List<string?>? photos)
    {
        _attributes = attributes;
        _year = year;
        _category = category;
        _maker = maker;
        _model = model;
        _color = color;
        _power = power;
        _petroleum = petroleum;
        _mileage = mileage;
        _gear = gear;
        _newCar = newCar;
        _price = price;
        _vin = vin;
        _additional = additional;
        _seller = seller;
        _engineVolume = engineVolume;
        _transmission = transmission;
        _photos = photos;
    }

    public List<string?>? photos
    {
        get => _photos;
        set
        {
            _photos = value;
            WhenPropertyChanged();
        }
    }

    //-----------------Seller Class---------------------
    public class Seller : INotifyPropertyChanged
    {
        //---------------------------------Private Variables---------------------------------
        private string? _name; // Seller Username
        private List<string>? _phone; // Seller Phones


        //--------------------------------Public Properties--------------------------------
        public string? name
        {
            get => _name;
            set
            {
                _name = value;
                WhenPropertyChanged();
            }
        }
        public List<string>? phone
        {
            get => _phone;
            set
            {
                _phone = value;
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



    //----------------Public Properties------------------

    public string? vin
    {
        get => _vin;
        set
        {
            _vin = value;
            WhenPropertyChanged();
        }
    }
    public Guid carId
    {
        get => _carId;
        set
        {
            _carId = value;
            WhenPropertyChanged();
        }
    }
    public List<string?>? attributes
    {
        get => _attributes; set
        {
            _attributes = value;
            WhenPropertyChanged();
        }
    }
    public string? year
    {
        get => _year;
        set
        {
            _year = value;
            WhenPropertyChanged();
        }
    }
    public string? category
    {
        get => _category; set
        {
            _category = value;
            WhenPropertyChanged();
        }
    }
    public string? maker
    {
        get => _maker;
        set
        {
            _maker = value;
            WhenPropertyChanged();
        }
    }
    public string? model
    {
        get => _model;
        set
        {
            _model = value;
            WhenPropertyChanged();
        }
    }
    public string? color
    {
        get => _color;
        set
        {
            _color = value;
            WhenPropertyChanged();
        }
    }
    public string? power
    {
        get => _power;
        set
        {
            _power = value;
            WhenPropertyChanged();
        }
    }
    public string? petroleum
    {
        get => _petroleum;
        set
        {
            _petroleum = value;
            WhenPropertyChanged();
        }
    }
    public string? mileage
    {
        get => _mileage;
        set
        {
            _mileage = value;
            WhenPropertyChanged();
        }
    }
    public string? place
    {
        get => _place; set
        {
            _place = value;
            WhenPropertyChanged();
        }
    }
    public string? gear
    {
        get => _gear;
        set
        {
            _gear = value;
            WhenPropertyChanged();
        }
    }
    public string? newCar
    {
        get => _newCar;
        set
        {
            _newCar = value;
            WhenPropertyChanged();
        }
    }
    public string? price
    {
        get => _price;
        set
        {
            _price = value;
            WhenPropertyChanged();
        }
    }
    public string? additional
    {
        get => _additional;
        set
        {
            _additional = value;
            WhenPropertyChanged();
        }
    }
    public Seller? seller
    {
        get => _seller;
        set
        {
            _seller = value;
            WhenPropertyChanged();
        }
    }
    public string? engineVolume
    {
        get => _engineVolume;
        set
        {
            string stringValue = value!;



            string[] parts = stringValue.Split(' ');



            if (parts.Length >= 2)
            {
                string numericPart = parts[0];



                if (double.TryParse(numericPart, out double result))
                {
                    double convertedValue = result / 1000.0;
                    string appendedValue = convertedValue.ToString("F1") + " L";
                    _engineVolume = appendedValue;
                    WhenPropertyChanged();
                }

            }
        }
    }
    public string? transmission
    {
        get => _transmission;
        set
        {
            _transmission = value;
            WhenPropertyChanged();
        }
    }
    //-------------------------------------------------------------------------------------------



    // ->> InotifyFunction <<-- //
    public event PropertyChangedEventHandler? PropertyChanged;

    public void WhenPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }


}