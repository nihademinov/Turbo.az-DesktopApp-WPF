using System.Windows;
using System.Windows.Navigation;
using Turbo.az_Desktop_App.ViewModels;
using Turbo.az_Desktop_App.Views.Pages;


namespace Turbo.az_Desktop_App.Views
{
    /// <summary>
    /// Interaction logic for MainwindowView.xaml
    /// </summary>
    public partial class MainwindowView : Window
    {
        public static MainwindowView ?mainWindowObject;
        // Bu vallue static oldugu ucun heryerde cagirilib istifade edile bilir

        public MainwindowView()
        {
           
            DataContext = new MainWindowViewModel();
            InitializeComponent();
            mainWindowObject = this;
        }

        private void QiymetMinTextBox_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if(QiymetMinTextBox.Text== "Qiymət, min."  || QiymetMinTextBox.Text== "Цена от")
            {
                QiymetMinTextBox.Text = "";
            }
        }

        private void QiymetMaxTextBox_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if(QiymetMaxTextBox.Text== "maks." || QiymetMaxTextBox.Text== "До")
            {
                QiymetMaxTextBox.Text = "";
            }
                    
        }

        private void QiymetMinTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            string word=QiymetMinTextBox.Text;
            if (word == "Qiymət, min." || word == "Цена от")
                return;
            foreach(char  c in word) 
            {
                if(char.IsLetter(c))
                {
                    QiymetMinTextBox.Text = "";
                    break;
                }
            }
        }

        private void QiymetMaxTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            string word = QiymetMaxTextBox.Text;
            if (word == "maks." || word == "До")
                return;
            foreach (char c in word)
            {
                if (char.IsLetter(c))
                {
                    QiymetMaxTextBox.Text = "";
                    break;
                }
            }
        }

        
    }
}
