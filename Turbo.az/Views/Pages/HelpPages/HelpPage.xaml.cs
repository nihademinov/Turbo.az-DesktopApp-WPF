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
using Turbo.az_Desktop_App.Commands;

using Turbo.az_Desktop_App.ViewModels;

namespace Turbo.az_Desktop_App.Views.Pages
{

    public partial class HelpPage : Page
    {
        public HelpPage(string? diltext)
        {

            InitializeComponent();
            HelpPageViewModel helpPageViewModel = new HelpPageViewModel(diltext);
            helpPageViewModel.HelpInsideFrameProperty = HelpPageInsideFrame;
            DataContext = helpPageViewModel;
        }

    }
}
