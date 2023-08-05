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
using Turbo.az_Desktop_App.ViewModels.LoginPageViewModels;

namespace Turbo.az_Desktop_App.Views.Pages.LoginPage
{
    /// <summary>
    /// Interaction logic for UserVerificationPage.xaml
    /// </summary>
    public partial class UserVerificationPage : Page
    {
        public UserVerificationPage(string? diltext, string? gmail)
        {
            DataContext = new UserVerificationLoginPageViewModel(diltext,gmail);
            InitializeComponent();
        }
    }
}
