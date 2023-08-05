using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Turbo.az_Desktop_App.Commands;
using Turbo.az_Desktop_App.Views.Pages;

namespace Turbo.az_Desktop_App.ViewModels
{
    public class HelpPageViewModel : INotifyPropertyChanged
    {
        private string? _salamText;
        private string? _popularSuallarText;
        private string? _elanText;

        public string? salamText
        {
            get => _salamText;
            set
            {
                _salamText = value;
                WhenPropertyChanged();
            }
        }
        public string? popularSuallarText
        {
            get => _popularSuallarText;
            set
            {
                _popularSuallarText = value;
                WhenPropertyChanged();
            }
        }


        public string? elanText
        {
            get => _elanText;
            set
            {
                _elanText = value;
                WhenPropertyChanged();
            }
        }

        public string? dilText { get; set; }





        public ICommand? ElanCommand { get; set; }
        public ICommand? PopularQuestionCommand { get; set; }
        public Frame? HelpInsideFrameProperty { get; set; }
        public Frame? HelpInsidePopularP { get; set; }

        public HelpPageViewModel(string? diltext)
        {
            dilText = diltext;
            ElanCommand = new RealCommand(elanBtn);
            PopularQuestionCommand = new RealCommand(popularQuestBtn);


            if (dilText == "RU")
            {
                salamText = "Salam! Sizə necə kömək edə bilərik?";
                popularSuallarText = "Popular suallar";
                elanText = "Elan";
            }
            else
            {
                salamText = "Привет! Как мы можем помочь вам?";
                popularSuallarText = "Популярные вопросы";
                elanText = "Объявление";
            }


        }

        public void elanBtn(object? parametr)
        {
            

            HelpInsideFrameProperty!.Content = new HelpInsideElanPage(dilText);
        }

        public void popularQuestBtn(object? parametr)
        {
            HelpInsideFrameProperty!.Content = new HelpInsidePopularQuestionPage(dilText);

        }







        // ->> InotifyFunction <<-- //

        public event PropertyChangedEventHandler? PropertyChanged;

        public void WhenPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
