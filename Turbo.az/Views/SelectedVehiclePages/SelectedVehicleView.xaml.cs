using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Turbo.az_Desktop_App.Models;
using Turbo.az_Desktop_App.ViewModels.SelectedVehiclePageViewModels;

namespace Turbo.az_Desktop_App.Views.SelectedVehiclePages
{
    /// <summary>
    /// Interaction logic for SelectedVehicleView.xaml
    /// </summary>
    public partial class SelectedVehicleView : Page
    {
        public SelectedVehicleView(VehicleModel? selected,string? diltext)
        {
            DataContext=new SelectedVehicleViewModel(selected, diltext);
            InitializeComponent();
        }
    }
}
