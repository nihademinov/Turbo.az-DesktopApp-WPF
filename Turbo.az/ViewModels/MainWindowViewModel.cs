using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Threading;
using Turbo.az_Desktop_App.Commands;
using Turbo.az_Desktop_App.Database;
using Turbo.az_Desktop_App.Models;
using Turbo.az_Desktop_App.ViewModels.SelectedVehiclePageViewModels;
using Turbo.az_Desktop_App.Views;
using Turbo.az_Desktop_App.Views.Pages;
using Turbo.az_Desktop_App.Views.SelectedVehiclePages;

namespace Turbo.az_Desktop_App.ViewModels;

internal class MainWindowViewModel : INotifyPropertyChanged
{
    public CarsDatabase _VehiclesDb = new CarsDatabase();

    public CarsDatabase VehiclesDb
    {
        get { return _VehiclesDb; }
        set
        {
            _VehiclesDb = value;
            WhenPropertyChanged();
        }
    }

    private string? _currentAds;
    private string? _desdekText;
    private string? _yardimText;
    private string? _dilText;
    private string? _secilmislerText;
    private string? _girisText;
    private string? _butunElanlarText;
    private string? _webSaytText;
    private string? _ehtiyatHisselerText;
    private string? _yeniElanText;
    private string? _yeniElanMargin;
    private string? _yeniElanWith;
    private UserModel? _currentUser;
    private string? _hamisiText;
    private string? _yeniText;
    private string? _surulmusText;
    private List<string?>? _rayonlar = new List<string?>();
    private List<string?>? _illerMin = new();
    private List<string?>? _illerMax = new();
    private string? _selectedIndexMin;
    private string? _selectedIndexMax;
    private string? _selectedSeher;
    private List<string?>? _ban = new();
    private string? _selectedBan;
    private List<string?>? _oturucu = new();
    private string? _selectedOturucu;
    private string? _minQiymetText;
    private string? _maxQiymetText;
    private string? _elanlariGosterText;
    private string? _sifirlaText;
    private string? _bugunkiElanlarText;
    private string? _hamisiButtonBack;
    private string? _yeniButtonBack;
    private string? _surulmusButtonBack;
    private string? _hamisiButtonForeground;
    private string? _yeniButtonForeground;
    private string? _surulmusButtonForeground;
    private ObservableCollection<VehicleModel> _showedVehicles = new();
    private VehicleModel? _selectedVehiclee;
    private ObservableCollection<string>? marka;
    private string? _selectedMarka;
    private readonly DispatcherTimer? _timerAds;


    //---------------------Button and TextBlock Contents------------------------


    public List<string[]> Markers { get; set; } = new();


    public ObservableCollection<VehicleModel> showedVehicles
    {
        get => _showedVehicles;
        set
        {
            _showedVehicles = value;
            WhenPropertyChanged();
        }
    }

    public string? desdekText
    {
        get => _desdekText;
        set
        {
            _desdekText = value;
            WhenPropertyChanged();
        }
    }
    public string? yardimText
    {
        get => _yardimText;
        set
        {
            _yardimText = value;
            WhenPropertyChanged();
        }
    }
    public string? dilText
    {
        get => _dilText;
        set
        {
            _dilText = value;
            WhenPropertyChanged();
        }
    }
    public string? secilmislerText
    {
        get => _secilmislerText;
        set
        {
            _secilmislerText = value;
            WhenPropertyChanged();
        }
    }

    public string? girisText
    {
        get => _girisText;
        set
        {
            _girisText = value;
            WhenPropertyChanged();
        }
    }

    public string? butunElanlarText
    {
        get => _butunElanlarText;
        set
        {
            _butunElanlarText = value;
            WhenPropertyChanged();
        }
    }
    public string? webSaytText
    {
        get => _webSaytText;
        set
        {
            _webSaytText = value;
            WhenPropertyChanged();
        }
    }

    public string? ehtiyatHisseleriText
    {
        get => _ehtiyatHisselerText;
        set
        {
            _ehtiyatHisselerText = value;
            WhenPropertyChanged();
        }
    }

    public string? yeniElanText
    {
        get => _yeniElanText;
        set
        {
            _yeniElanText = value;
            WhenPropertyChanged();
        }
    }

    public string? yeniElanMargin
    {
        get => _yeniElanMargin;
        set
        {
            _yeniElanMargin = value;
            WhenPropertyChanged();
        }
    }

    public string? yeniElanWith
    {
        get => _yeniElanWith;
        set
        {
            _yeniElanWith = value;
            WhenPropertyChanged();
        }
    }


    //--------------------------Veziyeti Text------------------------------------
    public string? hamisiText
    {
        get => _hamisiText;
        set
        {
            _hamisiText = value;
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

    public string? surulmusText
    {
        get => _surulmusText;
        set
        {
            _surulmusText = value;
            WhenPropertyChanged();
        }
    }
    //---------------------------------------------------------------------------

    public UserModel? currentUser
    {
        get => _currentUser;
        set
        {
            _currentUser = value;
            WhenPropertyChanged();
        }
    }

    public List<string?>? rayonlar
    {
        get => _rayonlar;
        set
        {
            _rayonlar = value;
            WhenPropertyChanged();
        }
    }
    //-----------------------------------------------------------------------------------------

    public List<string?>? illerMin
    {
        get => _illerMin;
        set
        {
            _illerMin = value;
            WhenPropertyChanged();
        }
    }

    public List<string?>? illerMax
    {
        get => _illerMax;
        set
        {
            _illerMax = value;
            WhenPropertyChanged();
        }
    }

    //-----------------------------------------------------------------------------------------


    public string? selectedIndexMin
    {
        get => _selectedIndexMin; set
        {
            _selectedIndexMin = value;
            WhenPropertyChanged();
        }
    }

    public string? selectedIndexMax
    {
        get => _selectedIndexMax; set
        {
            _selectedIndexMax = value;
            WhenPropertyChanged();
        }
    }
    public string? selectedSeher
    {
        get => _selectedSeher;
        set
        {
            _selectedSeher = value;
            WhenPropertyChanged();
        }
    }

    public List<string?>? ban
    {
        get => _ban;
        set
        {
            _ban = value;
            WhenPropertyChanged();
        }
    }
    public string? selectedBan
    {
        get => _selectedBan;
        set
        {
            _selectedBan = value;
            WhenPropertyChanged();
        }
    }

    public List<string?>? oturucu
    {
        get => _oturucu;
        set
        {
            _oturucu = value;
            WhenPropertyChanged();
        }
    }

    public string? selectedOturucu
    {
        get => _selectedOturucu;
        set
        {
            _selectedOturucu = value;
            WhenPropertyChanged();
        }
    }

    //-----------------------------------------------------------------------------------------


    public string? minQiymetText
    {
        get => _minQiymetText;
        set
        {
            _minQiymetText = value;
            WhenPropertyChanged();
        }
    }

    public string? maxQiymetText
    {
        get => _maxQiymetText;
        set
        {
            _maxQiymetText = value;
            WhenPropertyChanged();
        }
    }

    public string? elanlariGosterText
    {
        get => _elanlariGosterText;
        set
        {
            _elanlariGosterText = value;
            WhenPropertyChanged();
        }
    }

    public string? sifirlaText
    {
        get => _sifirlaText;
        set
        {
            _sifirlaText = value;
            WhenPropertyChanged();
        }
    }

    public string? bugunkiElanlarText
    {
        get => _bugunkiElanlarText;
        set
        {
            _bugunkiElanlarText = value;
            WhenPropertyChanged();
        }
    }


    public string? selectedMarka
    {
        get => _selectedMarka; set
        {
            _selectedMarka = value;
            WhenPropertyChanged();
        }
    }

    public string? HamisiButtonBack
    {
        get => _hamisiButtonBack; set
        {
            _hamisiButtonBack = value;
            WhenPropertyChanged();
        }
    }
    public string? YeniButtonBack
    {
        get => _yeniButtonBack; set
        {
            _yeniButtonBack = value;
            WhenPropertyChanged();
        }
    }
    public string? SurulmusButtonBack
    {
        get => _surulmusButtonBack;
        set
        {
            _surulmusButtonBack = value;
            WhenPropertyChanged();
        }
    }

    public string? HamisiButtonForeground
    {
        get => _hamisiButtonForeground;
        set
        {
            _hamisiButtonForeground = value;
            WhenPropertyChanged();
        }
    }
    public string? YeniButtonForeground
    {
        get => _yeniButtonForeground; set
        {
            _yeniButtonForeground = value;
            WhenPropertyChanged();
        }
    }
    public string? SurulmusButtonForeground
    {
        get => _surulmusButtonForeground; set
        {
            _surulmusButtonForeground = value;
            WhenPropertyChanged();
        }
    }
    public VehicleModel? selectedVehiclee
    {
        get => _selectedVehiclee;
        set
        {
            _selectedVehiclee = value;
            WhenPropertyChanged();
        }
    }

    public ObservableCollection<string> Marka
    {
        get => marka!; set
        {
            marka = value;
            WhenPropertyChanged();
        }
    }


    public ICommand? TapAzCommand { get; set; }
    public ICommand? BinaAzCommand { get; set; }
    public ICommand? BossAzCommand { get; set; }
    public ICommand? HeaderAdsCommand { get; set; }
    public ICommand? WebsiteCommand { get; set; }
    public ICommand? ChangeLanguageCommand { get; set; }
    public ICommand? SecilmislerCommand { get; set; }
    public ICommand? HelpCommand { get; set; }
    public ICommand? BackCommand { get; set; }
    public ICommand? AheadCommand { get; set; }
    public ICommand? YeniElanCommand { get; set; }
    public ICommand? GirisCommand { get; set; }
    public ICommand? ReloadCommand { get; set; }
    public ICommand? ButunElanlarCommand { get; set; }
    public ICommand? EhtiyatHisseleriCommand { get; set; }
    public ICommand? SifirlaCommand { get; set; }
    public ICommand? ClickVehicleCommand { get; set; }

    public ICommand? HamisiCommand { get; set; }
    public ICommand? YeniCommand { get; set; }
    public ICommand? SurulmusCommand { get; set; }
    public ICommand? ElaniGosterCommand { get; set; }
    public ICommand? BugunkiElanCommand { get; set; }



    public string? currentAds
    {
        get => _currentAds;
        set
        {
            _currentAds = value;
            WhenPropertyChanged();
        }
    }


    public MainWindowViewModel()
    {



        MarksDatabase markDB = new MarksDatabase();
        Markers = markDB.Marks;

        showedVehicles = VehiclesDb!.AllVehicles!;
        File.Delete("currentUser.json");
        HamisiButtonBack = "#C41313";
        SurulmusButtonBack = "White";
        YeniButtonBack = "White";

        HamisiButtonForeground = "White";
        SurulmusButtonForeground = "Gray";
        YeniButtonForeground = "Gray";

        hamisiText = "Hamısı";
        yeniText = "Yeni";
        surulmusText = "Sürülmüş";
        selectedMarka = "Marka";


        minQiymetText = "Qiymət, min.";
        maxQiymetText = "maks.";

        elanlariGosterText = "Elanları göstər";
        sifirlaText = "Sıfırla";
        bugunkiElanlarText = "Bugünki Elanlar";

        using FileStream fs = new FileStream("rayonlar.json", FileMode.Open);
        rayonlar = JsonSerializer.Deserialize<List<string?>>(fs);
        selectedSeher = "Şəhər";
        using FileStream fs_1 = new FileStream("illerMin.json", FileMode.Open);
        illerMin = JsonSerializer.Deserialize<List<string?>>(fs_1);
        using FileStream fs_2 = new FileStream("illerMaks.json", FileMode.Open);
        illerMax = JsonSerializer.Deserialize<List<string?>>(fs_2);
        using FileStream fs_3 = new FileStream("ban.json", FileMode.Open);
        ban = JsonSerializer.Deserialize<List<string?>>(fs_3);
        using FileStream fs_4 = new FileStream("oturucu.json", FileMode.Open);
        oturucu = JsonSerializer.Deserialize<List<string?>>(fs_4);

        using FileStream fs_5 = new FileStream("Marka.json", FileMode.Open);
        Marka = JsonSerializer.Deserialize<ObservableCollection<string?>?>(fs_5);
        selectedOturucu = "Ötürücü";

        selectedIndexMin = "İl, min.";
        selectedIndexMax = "maks.";
        selectedBan = "Ban növü";


        desdekText = "Dəstək: (012)-505-77-55";
        yardimText = "Yardım";
        dilText = "RU";
        secilmislerText = "Seçilmişlər";
        if (currentUser == null)
        { girisText = "Giriş"; }
        else
        { girisText = "Çıxış"; }
        butunElanlarText = "Bütün elanlar";
        webSaytText = "Websayt";
        ehtiyatHisseleriText = "Ehtiyyat hissələr və aksesuarlar";
        yeniElanText = "Yeni elan";
        yeniElanMargin = "80,0,0,0";
        yeniElanWith = "90";


        currentAds = "/StaticFiles/WindowImages/umicoReklam.png";
        TapAzCommand = new RealCommand(OpenTapAz);
        BinaAzCommand = new RealCommand(OpenBinaAz);
        EhtiyatHisseleriCommand = new RealCommand(OpenEhtiyatHisseleriAds);
        BossAzCommand = new RealCommand(OpenBossAz);
        HeaderAdsCommand = new RealCommand(OpenHeaderAds);
        ChangeLanguageCommand = new RealCommand(ChangeLanguage);
        SecilmislerCommand = new RealCommand(OpenSecilmislerPage);
        HelpCommand = new RealCommand(OpenHelpPage);
        BackCommand = new RealCommand(GoBack);
        GirisCommand = new RealCommand(OpenSignInPage);
        ButunElanlarCommand = new RealCommand(BackButunElanlarPage);
        ReloadCommand = new RealCommand(ReloadPage);
        YeniElanCommand = new RealCommand(OpenCreateVehiclePage);
        SifirlaCommand = new RealCommand(SifirlaFunction);
        ClickVehicleCommand = new RealCommand(OpenClickVehiclePage);
        WebsiteCommand = new RealCommand(OpenWebSite);
        HamisiCommand = new RealCommand(HamisiButtonClick);
        YeniCommand = new RealCommand(YeniButtonClick);
        SurulmusCommand = new RealCommand(SurulmusButtonClick);
        ElaniGosterCommand = new RealCommand(ElaniGoster);
        BugunkiElanCommand = new RealCommand(ShowBugunkiElan);

        _timerAds = new DispatcherTimer();
        _timerAds.Interval = TimeSpan.FromSeconds(5);
        _timerAds.Tick += Timer_Tick;
        _timerAds.Start();

    }



    public void OpenTapAz(object? parametr)
    {
        string websiteUrl = "https://tap.az/";

        Process.Start(new ProcessStartInfo
        {
            FileName = websiteUrl,
            UseShellExecute = true

        });
    }

    public void OpenBinaAz(object? parametr)
    {
        string websiteUrl = "https://bina.az/";

        Process.Start(new ProcessStartInfo
        {
            FileName = websiteUrl,
            UseShellExecute = true
        });
    }

    public void OpenWebSite(object? parametr)
    {
        string websiteUrl = "https://turbo.az/";

        Process.Start(new ProcessStartInfo
        {
            FileName = websiteUrl,
            UseShellExecute = true
        });
    }


    public void ReloadPage(object? parametr)
    {
        showedVehicles = VehiclesDb!.AllVehicles!;
        SifirlaFunction("a");
        try
        {
            using FileStream fs = new FileStream("currentUser.json", FileMode.Open);
            currentUser = JsonSerializer.Deserialize<UserModel>(fs);
        }
        catch
        {
            return;
        }
        if (dilText == "RU")
        {
            if (currentUser == null)
            { girisText = "Giriş"; }
            else
            { girisText = "Çıxış"; }
        }
        else
        {
            if (currentUser == null)
            { girisText = "Войти"; }
            else
            { girisText = "Выход"; }
        }
    }

    public void ShowBugunkiElan(object? parametr)
    {
        showedVehicles = VehiclesDb!.AllNewVehicles!;
    }
    public void OpenBossAz(object? parametr)
    {
        string websiteUrl = "https://boss.az/";

        Process.Start(new ProcessStartInfo
        {
            FileName = websiteUrl,
            UseShellExecute = true
        });
    }

    public void OpenHeaderAds(object? parametr)
    {
        string websiteUrl;
        if (currentAds == "/StaticFiles/WindowImages/wolkswagenReklam.png")
        {
            websiteUrl = "https://www.volkswagenauto.az/az";
        }
        else
        {
            websiteUrl = "https://umico.az/?utm_source=google&utm_medium=cpc&utm_content=Umico_ru&utm_term=umico&utm_campaign=Brand_Umico&gclid=EAIaIQobChMIqqH76LKYgAMVb0GRBR06JgKUEAAYASAAEgI9xPD_BwE";
        }
        Process.Start(new ProcessStartInfo
        {
            FileName = websiteUrl,
            UseShellExecute = true
        });
    }

    public void HamisiButtonClick(object? parametr)
    {
        HamisiButtonBack = "#C41313";
        SurulmusButtonBack = "White";
        YeniButtonBack = "White";
        HamisiButtonForeground = "White";
        SurulmusButtonForeground = "Gray";
        YeniButtonForeground = "Gray";
    }

    public void YeniButtonClick(object? parametr)
    {
        HamisiButtonBack = "White";
        SurulmusButtonBack = "White";
        YeniButtonBack = "#C41313";
        HamisiButtonForeground = "Gray";
        SurulmusButtonForeground = "Gray";
        YeniButtonForeground = "White";
    }
    public void SurulmusButtonClick(object? parametr)
    {
        HamisiButtonBack = "White";
        SurulmusButtonBack = "#C41313";
        YeniButtonBack = "White";
        HamisiButtonForeground = "Gray";
        SurulmusButtonForeground = "White";
        YeniButtonForeground = "Gray";
    }
    public void OpenEhtiyatHisseleriAds(object? parametr)
    {
        string websiteUrl = "https://tap.az/elanlar/neqliyyat/ehtiyyat-hisseleri-ve-aksesuarlar?utm_source=turboaz&utm_medium=link&utm_content=accessories&utm_campaign=desktop#_gl=1*qtlxey*_ga*MzAxNzAxODI1LjE2ODg3OTkyNjI.*_ga_68B6PJZXYD*MTY5MDU5MjI5NS41OC4xLjE2OTA1OTI2NjIuNjAuMC4w";

        Process.Start(new ProcessStartInfo
        {
            FileName = websiteUrl,
            UseShellExecute = true
        });
    }

    public void ElaniGoster(object? parametr)
    {
        if (selectedBan != "Ban növü" && selectedBan != "Тип кузова")
        {
            showedVehicles = VehiclesDb.FilterForBan(VehiclesDb.AllVehicles!, selectedBan);
        }


        if (SurulmusButtonForeground == "White")
        {
            showedVehicles = VehiclesDb.FilterForNewCar(VehiclesDb.AllVehicles!, "Xeyr");
        }
        if (YeniButtonForeground == "White")
        {
            showedVehicles = VehiclesDb.FilterForNewCar(VehiclesDb.AllVehicles!, "Bəli");
        }
        if (selectedOturucu != "Ötürücü" && selectedOturucu != "Привод")
        {
            showedVehicles = VehiclesDb.FilterForOturucu(VehiclesDb!.AllVehicles!, selectedOturucu);
        }
        if (selectedSeher != "Şəhər" && selectedSeher != "Город")
        {
            showedVehicles = VehiclesDb.FilterForSeher(VehiclesDb!.AllVehicles!, selectedSeher);
        }
        if (selectedMarka!="Marka" && selectedMarka!= "Марка")
        {
            showedVehicles = VehiclesDb.FilterForMarka(VehiclesDb!.AllVehicles!, selectedMarka);
        }
        if (selectedIndexMin!= "Qiymət, min." && selectedIndexMin!= "Год от")
        {

        }
        SifirlaFunction("a");
    }

    public void BackButunElanlarPage(object? parametr)
    {
        showedVehicles = VehiclesDb!.AllVehicles!;
        SifirlaFunction("a");
        MainwindowView.mainWindowObject!.Mainframe.Content = new EmptyPage();
    }
    public void ChangeLanguage(object? parametr)
    {

        if (dilText == "RU")
        {
            selectedMarka = "Марка";
            using FileStream fs = new FileStream("rayonlarRU.json", FileMode.Open);
            rayonlar = JsonSerializer.Deserialize<List<string?>>(fs);
            selectedSeher = "Город";
            selectedIndexMin = "Год от";
            selectedIndexMax = "До";
            using FileStream fs_1 = new FileStream("illerMinRU.json", FileMode.Open);
            illerMin = JsonSerializer.Deserialize<List<string?>>(fs_1);

            using FileStream fs_2 = new FileStream("illerMaksRU.json", FileMode.Open);
            illerMax = JsonSerializer.Deserialize<List<string?>>(fs_2);

            using FileStream fs_3 = new FileStream("banRU.json", FileMode.Open);
            ban = JsonSerializer.Deserialize<List<string?>>(fs_3);
            selectedBan = "Тип кузова";
            using FileStream fs_4 = new FileStream("oturucuRU.json", FileMode.Open);
            oturucu = JsonSerializer.Deserialize<List<string?>>(fs_4);
            using FileStream fs_5 = new FileStream("MarkaRU.json", FileMode.Open);
            oturucu = JsonSerializer.Deserialize<List<string?>>(fs_5);
            selectedOturucu = "Привод";

            minQiymetText = "Цена от";
            maxQiymetText = "До";

            elanlariGosterText = "Показать объявления";

            hamisiText = "Все";
            yeniText = "Новые";
            surulmusText = "Побегом";
            sifirlaText = "Сбросить";
            bugunkiElanlarText = "Сегодняшние объявления";
            dilText = "AZ";
            desdekText = "Поддержка: (012)-505-77-55";
            yardimText = "Помощь";
            secilmislerText = "Избранное";
            if (currentUser == null)
            { girisText = "Войти"; }
            else
            { girisText = "Выход"; }
            butunElanlarText = "Все объявления";
            webSaytText = "Веб-сайт";
            ehtiyatHisseleriText = "Запчасти и аксессуары";
            yeniElanText = "Добавить объявление";
            yeniElanMargin = "30,0,0,0";
            yeniElanWith = "185";
            if (MainwindowView.mainWindowObject!.Mainframe.Content != null)
            {
                if (MainwindowView.mainWindowObject!.Mainframe.Content.ToString() == "Turbo.az_Desktop_App.Views.Pages.SecilmislerErrorPage")
                { MainwindowView.mainWindowObject!.Mainframe.Content = new SecilmislerErrorPage(dilText); }
                else if (MainwindowView.mainWindowObject!.Mainframe.Content.ToString() == "Turbo.az_Desktop_App.Views.Pages.CreateNewVehiclePage")
                { MainwindowView.mainWindowObject!.Mainframe.Content = new CreateNewVehiclePage(dilText); }
                else if (MainwindowView.mainWindowObject!.Mainframe.Content.ToString() == "Turbo.az_Desktop_App.Views.Pages.HelpPage")
                { MainwindowView.mainWindowObject!.Mainframe.Content = new HelpPage(dilText); }
                else if (MainwindowView.mainWindowObject!.Mainframe.Content.ToString() == "Turbo.az_Desktop_App.Views.SelectedVehiclePages.SelectedVehicleView")
                { MainwindowView.mainWindowObject!.Mainframe.Content = new SelectedVehicleView(selectedVehiclee, dilText); }
            }

        }
        else if (dilText == "AZ")
        {
            using FileStream fs = new FileStream("rayonlar.json", FileMode.Open);
            rayonlar = JsonSerializer.Deserialize<List<string?>>(fs);
            selectedSeher = "Şəhər";


            using FileStream fs_1 = new FileStream("illerMin.json", FileMode.Open);
            illerMin = JsonSerializer.Deserialize<List<string?>>(fs_1);

            using FileStream fs_2 = new FileStream("illerMaks.json", FileMode.Open);
            illerMax = JsonSerializer.Deserialize<List<string?>>(fs_2);

            using FileStream fs_3 = new FileStream("ban.json", FileMode.Open);
            ban = JsonSerializer.Deserialize<List<string?>>(fs_3);
            selectedBan = "Ban növü";

            using FileStream fs_4 = new FileStream("oturucu.json", FileMode.Open);
            oturucu = JsonSerializer.Deserialize<List<string?>>(fs_4);

            using FileStream fs_5 = new FileStream("Marka.json", FileMode.Open);
            Marka = JsonSerializer.Deserialize<ObservableCollection<string>>(fs_5);
            selectedMarka = "Marka";
            selectedOturucu = "Ötürücü";

            minQiymetText = "Qiymət, min.";
            maxQiymetText = "maks.";
            
            elanlariGosterText = "Elanları göstər";
            sifirlaText = "Sıfırla";
            bugunkiElanlarText = "Bugünki Elanlar";
            hamisiText = "Hamısı";
            yeniText = "Yeni";
            surulmusText = "Sürülmüş";
            selectedIndexMin = "İl, min.";
            selectedIndexMax = "maks.";
            desdekText = "Dəstək: (012)-505-77-55";
            yardimText = "Yardım";
            dilText = "RU";
            secilmislerText = "Seçilmişlər";
            if (currentUser == null)
            { girisText = "Giriş"; }
            else
            { girisText = "Çıxış"; }
            butunElanlarText = "Bütün elanlar";
            webSaytText = "Websayt";
            ehtiyatHisseleriText = "Ehtiyyat hissələr və aksesuarlar";
            yeniElanText = "Yeni elan";
            yeniElanMargin = "80,0,0,0";
            yeniElanWith = "90";
            if (MainwindowView.mainWindowObject!.Mainframe.Content != null)
            {
                if (MainwindowView.mainWindowObject!.Mainframe.Content.ToString() == "Turbo.az_Desktop_App.Views.Pages.SecilmislerErrorPage")
                { MainwindowView.mainWindowObject!.Mainframe.Content = new SecilmislerErrorPage(dilText); }
                else if (MainwindowView.mainWindowObject!.Mainframe.Content.ToString() == "Turbo.az_Desktop_App.Views.Pages.CreateNewVehiclePage")
                { MainwindowView.mainWindowObject!.Mainframe.Content = new CreateNewVehiclePage(dilText); }
                else if (MainwindowView.mainWindowObject!.Mainframe.Content.ToString() == "Turbo.az_Desktop_App.Views.Pages.HelpPage")
                { MainwindowView.mainWindowObject!.Mainframe.Content = new HelpPage(dilText); }
                else if (MainwindowView.mainWindowObject!.Mainframe.Content.ToString() == "Turbo.az_Desktop_App.Views.SelectedVehiclePages.SelectedVehicleView")
                { MainwindowView.mainWindowObject!.Mainframe.Content = new SelectedVehicleView(selectedVehiclee, dilText); }

            }
        }
    }

    public void OpenSecilmislerPage(object? parametr)
    {
        if (girisText == "Giriş" || girisText == "Войти")
        {
            MainwindowView.mainWindowObject!.Mainframe.Content = new SecilmislerErrorPage(dilText);
        }
        else
        {

            MainwindowView.mainWindowObject!.Mainframe.Content = new SecilmislerPage(currentUser, dilText);
        }
    }


    public void OpenCreateVehiclePage(object? parametr)
    {
        MainwindowView.mainWindowObject!.Mainframe.Content = new CreateNewVehiclePage(dilText);
    }

    public void OpenClickVehiclePage(object? parametr)                                           //SELECTED OPEN VEHICLE
    {

        VehicleModel selectedVehicle = VehiclesDb.returnSelectedVehicle((Guid)parametr!);
        selectedVehiclee = selectedVehicle;
        SelectedVehicleView selected = new(selectedVehiclee, dilText);
        //selected.DataContext = new SelectedVehicleViewModel(selectedVehicle, dilText);

        MainwindowView.mainWindowObject!.Mainframe.Content = selected;
    }

    public void OpenHelpPage(object? parametr)
    {
        MainwindowView.mainWindowObject!.Mainframe.Visibility = Visibility.Visible;
        MainwindowView.mainWindowObject!.Mainframe.Content = new HelpPage(dilText);

    }

    public void OpenSignInPage(object? parametr)
    {
        if (girisText == "Giriş" || girisText == "Войти")
        {
            //MainwindowView.mainWindowObject!.Mainframe.Visibility = Visibility.Visible;
            MainwindowView.mainWindowObject!.AllWindowframe.Content = new SignInPage(dilText);
        }
        else
        {
            currentUser = null;
            File.Delete("currentUser.json");
            if (dilText == "RU")
            { girisText = "Giriş"; }
            else
            {
                girisText = "Войти";
            }

        }
    }

    public void GoBack(object? parametr)
    {
        MainwindowView.mainWindowObject!.Mainframe.Content = new EmptyPage();

        //if (MainwindowView.mainWindowObject!.Mainframe.CanGoBack != false)
        //{
        //    MainwindowView.mainWindowObject!.Mainframe.Visibility = Visibility.Visible;
        //    MainwindowView.mainWindowObject!.Mainframe.GoBack();
        //}
        //else
        //{
        //    MainwindowView.mainWindowObject!.Mainframe.Visibility=Visibility.Collapsed;


        //}
    }


    public void SifirlaFunction(object? parametr)
    {

        VehiclesDb.Shuffle();
        HamisiButtonBack = "#C41313";
        SurulmusButtonBack = "White";
        YeniButtonBack = "White";
        HamisiButtonForeground = "White";
        SurulmusButtonForeground = "Gray";
        YeniButtonForeground = "Gray";
        if (dilText == "RU")
        {
            selectedSeher = "Şəhər";
            selectedBan = "Ban növü";
            selectedOturucu = "Ötürücü";
            minQiymetText = "Qiymət, min.";
            maxQiymetText = "maks.";
            selectedIndexMin = "İl, min.";
            selectedIndexMax = "maks.";
        }
        else
        {
            selectedSeher = "Город";
            selectedIndexMin = "Год от";
            selectedIndexMax = "До";
            selectedBan = "Тип кузова";
            selectedOturucu = "Привод";
            minQiymetText = "Цена от";
            maxQiymetText = "До";
        }
    }



    private void Timer_Tick(object? sender, EventArgs e)
    {

        if (currentAds == "/StaticFiles/WindowImages/umicoReklam.png")
        {
            currentAds = "/StaticFiles/WindowImages/wolkswagenReklam.png";
        }
        else
        {
            currentAds = "/StaticFiles/WindowImages/umicoReklam.png";
        }

    }


    // ->> InotifyFunction <<-- //

    public event PropertyChangedEventHandler? PropertyChanged;

    public void WhenPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

}