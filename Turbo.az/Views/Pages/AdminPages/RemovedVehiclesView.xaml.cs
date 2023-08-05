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
using System.Xml;
using Turbo.az_Desktop_App.ViewModels.AdminPageViewModels;

namespace Turbo.az_Desktop_App.Views.Pages.AdminPages
{
    /// <summary>
    /// Interaction logic for RemovedVehiclesView.xaml
    /// </summary>
    public partial class RemovedVehiclesView : Page
    {
        public RemovedVehiclesView(string? diltext)
        {
            DataContext = new RemovedVehiclesViewModel(diltext);
            InitializeComponent();
        }
    }
}
