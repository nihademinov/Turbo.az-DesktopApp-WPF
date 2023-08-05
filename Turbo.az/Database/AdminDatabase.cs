using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_Desktop_App.Models;

namespace Turbo.az_Desktop_App.Database
{
    internal class AdminDatabase : INotifyPropertyChanged
    {
        private List<VehicleModel>? _waitingVehicle;
        private List<VehicleModel>? _removedVehicle;

        public List<AdminModel>? allAdmins { get; set; }

        public List<VehicleModel>? waitingVehicle
        {
            get => _waitingVehicle;
            set
            {
                _waitingVehicle = value;
                WhenPropertyChanged();
            }
        }
        public List<VehicleModel>? removedVehicle
        {
            get => _removedVehicle;
            set
            {
                _removedVehicle = value;
                WhenPropertyChanged();
            }
        }

        public AdminDatabase()
        {
            allAdmins = new List<AdminModel>()
            {
                new AdminModel(){gmail="admin@gmail.com" ,password="admin"},
                new AdminModel(){gmail="admin1@gmail.com" ,password="admin1"},
                new AdminModel(){gmail="admin2@gmail.com" ,password="admin2"},
                new AdminModel(){gmail="a" ,password="a"}
            };
        }




        public bool CheckAdmin(string? gmail,string? password)
        {
            foreach(AdminModel admin in allAdmins)
            {
                if(admin.gmail==gmail)
                {
                    if(admin.password==password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }



        // ->> InotifyFunction <<-- //

        public event PropertyChangedEventHandler? PropertyChanged;

        public void WhenPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
