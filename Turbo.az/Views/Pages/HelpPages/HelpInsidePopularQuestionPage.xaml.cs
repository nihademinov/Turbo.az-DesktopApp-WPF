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
using Turbo.az_Desktop_App.ViewModels;

namespace Turbo.az_Desktop_App.Views.Pages
{
    /// <summary>
    /// Interaction logic for HelpInsidePopularQuestionPage.xaml
    /// </summary>
    public partial class HelpInsidePopularQuestionPage : Page
    {
        public HelpInsidePopularQuestionPage(string? diltext)
        {
            DataContext = new HelpInsidePopularQuestionsViewModel(diltext);
            InitializeComponent();
        }
    }
}
