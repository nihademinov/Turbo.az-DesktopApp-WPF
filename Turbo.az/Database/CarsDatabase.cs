using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using Turbo.az_Desktop_App.Models;

namespace Turbo.az_Desktop_App.Database
{
    public class CarsDatabase : INotifyPropertyChanged
    {
        private ObservableCollection<VehicleModel?>? _allVehicles = new ObservableCollection<VehicleModel?>();
        private ObservableCollection<VehicleModel?>? _allNewVehicles = new ObservableCollection<VehicleModel?>();
        private ObservableCollection<VehicleModel?>? _allApiVehicles = new ObservableCollection<VehicleModel?>();
        private ObservableCollection<VehicleModel?>? _allWaitingVehicles = new ObservableCollection<VehicleModel?>();
        private ObservableCollection<VehicleModel?>? _allRemovedVehicles = new ObservableCollection<VehicleModel?>();

        public ObservableCollection<VehicleModel?>? AllApiVehicles
        {
            get { return _allApiVehicles; }
            set
            {
                _allApiVehicles = value;
                WhenPropertyChanged();
            }
        }

        public ObservableCollection<VehicleModel?>? AllNewVehicles
        {
            get { return _allNewVehicles; }
            set
            {
                _allNewVehicles = value;
                WhenPropertyChanged();
            }
        }


        public ObservableCollection<VehicleModel?>? AllVehicles
        {
            get { return _allVehicles; }
            set
            {
                _allVehicles = value;
                WhenPropertyChanged();
            }

        }

        public ObservableCollection<VehicleModel?>? AllWaitingVehicles
        {
            get => _allWaitingVehicles;
            set
            {
                _allWaitingVehicles = value;
                WhenPropertyChanged();
            }
        }

        public ObservableCollection<VehicleModel?>? AllRemovedVehicles
        {
            get => _allRemovedVehicles;
            set
            {
                _allRemovedVehicles = value;
                WhenPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public CarsDatabase()
        {
            var client = new HttpClient();
            var jsonApi = client.GetStringAsync("https://raw.githubusercontent.com/nihademinov/AllVehicleAPI/main/vehiclesApi130").Result;


            var allVehiclesApi = JsonSerializer.Deserialize<ObservableCollection<VehicleModel?>?>(jsonApi!);
            _allApiVehicles = allVehiclesApi;
            //using FileStream fs = new FileStream("NewAllVehicles.json", FileMode.OpenOrCreate);
            //fs.Close();
            string tempVehicles = File.ReadAllText("NewAllVehicles.json");

            var AllNewVehicles = Newtonsoft.Json.JsonConvert.DeserializeObject<ObservableCollection<VehicleModel?>>(tempVehicles);
            if (AllNewVehicles != null && allVehiclesApi != null)
            {
                var combinedCollection = new ObservableCollection<VehicleModel>(allVehiclesApi!.Concat(AllNewVehicles)!);
                _allVehicles = combinedCollection!;
            }
            else
            {
                _allVehicles = _allApiVehicles;
            }
            if (_allVehicles != null)
                ShuffleHelper.Shuffle(_allVehicles);

            //string tempVehicles = File.ReadAllText("testjson.json");
            //AllVehicles = Newtonsoft.Json.JsonConvert.DeserializeObject<ObservableCollection<VehicleModel?>>(tempVehicles);

            //JsonSerializerOptions options = new JsonSerializerOptions();
            //options.WriteIndented = true;




        }


        public CarsDatabase(bool check)
        {
            string tempVehicles = File.ReadAllText("AllWaitingVehicles.json");

             AllWaitingVehicles = Newtonsoft.Json.JsonConvert.DeserializeObject<ObservableCollection<VehicleModel?>>(tempVehicles);
            string tempVehicles_1 = File.ReadAllText("AllRemovedVehicles.json");

            AllRemovedVehicles = Newtonsoft.Json.JsonConvert.DeserializeObject<ObservableCollection<VehicleModel?>>(tempVehicles_1);


        }
        public void Shuffle()
        {
            ShuffleHelper.Shuffle(AllVehicles!);
        }
        private async void api()
        {
            var client = new HttpClient();
            var jsonApi = await client.GetStringAsync("https://raw.githubusercontent.com/nihademinov/AllVehicleAPI/main/vehiclesApi130");

        }

        public void AddVehicle(VehicleModel? newVehicle)
        {
            AllNewVehicles!.Add(newVehicle);
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            File.WriteAllText("NewAllVehicles.json", JsonSerializer.Serialize(AllNewVehicles, options));

            string tempVehicles = File.ReadAllText("NewAllVehicles.json");
            var AllNewVehiclesTemp = Newtonsoft.Json.JsonConvert.DeserializeObject<ObservableCollection<VehicleModel?>>(tempVehicles);
            if (AllNewVehiclesTemp != null)
            {
                var combinedCollection = new ObservableCollection<VehicleModel>(_allApiVehicles!.Concat(AllNewVehiclesTemp)!);
                _allVehicles = combinedCollection!;

            }

        }


        public VehicleModel returnSelectedVehicle(Guid id)
        {
            if (_allVehicles != null)
            {
                foreach (var item in _allVehicles)
                {
                    if (item!.carId == id)
                    {
                        return item;
                    }
                }

            }
            return null!;
        }


        public VehicleModel returnRemovedVehicle(Guid id)
        {
            if (_allVehicles != null)
            {
                foreach (var item in _allRemovedVehicles!)
                {
                    if (item!.carId == id)
                    {
                        return item;
                    }
                }

            }
            return null!;
        }


        public void RemoveWaitingVehicle(Guid id)
        {
            if (_allWaitingVehicles != null)
            {
                for(short a=0;a<_allWaitingVehicles?.Count;a++) 
                {
                    if (_allWaitingVehicles[a]!.carId== id)
                    {
                        _allRemovedVehicles?.Add(_allWaitingVehicles[a]);
                        _allWaitingVehicles.Remove(_allWaitingVehicles[a]);
                        JsonSerializerOptions options = new JsonSerializerOptions();
                        options.WriteIndented = true;
                        File.WriteAllText("AllWaitingVehicles.json", JsonSerializer.Serialize(_allWaitingVehicles, options));
                        File.WriteAllText("AllRemovedVehicles.json", JsonSerializer.Serialize(_allRemovedVehicles, options));

                    }
                }
            }
        }


        public void Submit(Guid id)
        {
            if (_allWaitingVehicles != null)
            {
                for (int a = 0; a < _allWaitingVehicles?.Count; a++)
                {
                    if (_allWaitingVehicles[a]!.carId == id)
                    {
                        _allNewVehicles?.Add(_allWaitingVehicles[a]);
                        _allWaitingVehicles.Remove(_allWaitingVehicles[a]);

                        JsonSerializerOptions options = new JsonSerializerOptions();
                        options.WriteIndented = true;
                        File.WriteAllText("AllWaitingVehicles.json", JsonSerializer.Serialize(_allWaitingVehicles, options));
                        File.WriteAllText("NewAllVehicles.json", JsonSerializer.Serialize(_allNewVehicles, options));
                    }
                }
            }
        }

        public VehicleModel returnSelectedWaitingVehicle(Guid id)
        {
            if (_allWaitingVehicles != null)
            {
                foreach (var item in _allWaitingVehicles)
                {
                    if (item!.carId == id)
                    {
                        return item;
                    }
                }
            }
            return null!;
        }


        //----------------------------------------------------------------------------Filters

        public ObservableCollection<VehicleModel> FilterForBan(ObservableCollection<VehicleModel>? vehicles,  string? ban)
        {
            ObservableCollection<VehicleModel> filteredVehicles = new ObservableCollection<VehicleModel>();
            foreach(VehicleModel vehicle in vehicles!)
            {
                if(vehicle!.category==ban)
                {
                    filteredVehicles.Add(vehicle);
                }
            }
            return filteredVehicles;
        }

        public ObservableCollection<VehicleModel> FilterForNewCar(ObservableCollection<VehicleModel> vehicles, string? newCar)
        {
            ObservableCollection<VehicleModel> filteredVehicles = new ObservableCollection<VehicleModel>();
            foreach (VehicleModel vehicle in vehicles)
            {
                if (vehicle.newCar == newCar)
                {
                    filteredVehicles.Add(vehicle);
                }
            }
            return filteredVehicles;
        }

        public ObservableCollection<VehicleModel> FilterForOturucu(ObservableCollection<VehicleModel> vehicles, string? oturucu)
        {
            ObservableCollection<VehicleModel> filteredVehicles = new ObservableCollection<VehicleModel>();
            foreach (VehicleModel vehicle in vehicles)
            {
                if (vehicle.gear == oturucu)
                {
                    filteredVehicles.Add(vehicle);
                }
            }
            return filteredVehicles;
        }

        public ObservableCollection<VehicleModel> FilterForSeher(ObservableCollection<VehicleModel> vehicles, string? seher)
        {
            ObservableCollection<VehicleModel> filteredVehicles = new ObservableCollection<VehicleModel>();
            foreach (VehicleModel vehicle in vehicles)
            {
                if (vehicle.place == seher)
                {
                    filteredVehicles.Add(vehicle);
                }
            }
            return filteredVehicles;
        }

        public ObservableCollection<VehicleModel> FilterForMarka(ObservableCollection<VehicleModel> vehicles, string? marka)
        {
            ObservableCollection<VehicleModel> filteredVehicles = new ObservableCollection<VehicleModel>();
            foreach (VehicleModel vehicle in vehicles)
            {
                if (vehicle.maker == marka)
                {
                    filteredVehicles.Add(vehicle);
                }
            }
            return filteredVehicles;
        }


        //public ObservableCollection<VehicleModel> FilterForMinQiymet(ObservableCollection<VehicleModel> vehicles, string min)
        //{
        //    ObservableCollection<VehicleModel> filteredVehicles = new ObservableCollection<VehicleModel>();
        //    foreach (VehicleModel vehicle in vehicles)
        //    {
        //        if (vehicle.price > int.Parse(min))
        //        {
        //            filteredVehicles.Add(vehicle);
        //        }
        //    }
        //    return filteredVehicles;
        //}
        //-----------------------------------------------------------------------------------




        // ->> InotifyFunction <<-- //

        public void WhenPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
