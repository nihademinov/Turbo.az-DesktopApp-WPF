using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az_Desktop_App.ViewModels
{
    public class CreateNewVehicleViewModel : INotifyPropertyChanged
    {
        private string? _informationTextTop;
        private string? _informationTextCenter;
        private string? _informationTextBottom;
        private string? _headerText;
        private string? _markaText;
        private string? _modelText;
        private string? _banText;
        private string? _yurusText;
        private string? _rengText;
        private string? _qiymetText;
        private string? _sahibText;
        private string? _veziyyetText;
        private string? _yerlerText;
        private string? _vinKodText;
        private string? _elaveMelumatText;
        private string? _avtomobilinTehcizatiText;
        private string? _vinKoduTapmaqText;
        private string? _yungulDisktText;
        private string? _merkeziQapanmaText;
        private string? _deriSalonText;
        private string? _oturacaqlarinVentilyasiyasiText;
        private string? _absText;
        private string? _parkRadariText;
        private string? _ksenonLampalarText;
        private string? _lyukText;
        private string? _kondisionerText;
        private string? _kameraText;
        private string? _yagisSensoruText;
        private string? _oturacaqlarinIsidilmesiText;
        private string? _yanPerdelerText;
        private string? _sekillerText;
        private string? _teleb1TextTop;
        private string? _teleb1TextBottom;
        private string? _teleb2Text;
        private string? _teleb3Text;
        private string? _elaqeText;
        private string? _elaqeInformationText;
        private string? _nameText;
        private string? _seherText;
        private string? _emailText;
        private string? _telefonNomresiText;
        private string? _davamEtText;
        private string? _razilasmaText;
        private string? _yanacaqText;
        private string? _oturucuText;
        private string? _suretlerQutusuText;
        private string? _ilText;
        private string? _muherrikinHecmiText;
        private string? _muherrikinGucu;
        private string? _hansiBazarUcunText;
        private string? _vuruguVarTextTop;
        private string? _vuruguVarTextBottom;
        private string? _renglenibTextTop;
        private string? _renglenibTextBottom;
        private string? _qezaliTextTop;
        private string? _qezaliTextBottom;
        private string? _qeydText;
        private string? _kreditText;
        private string? _barterText;
        private string? _vinInformation1TextTop;
        private string? _vinInformation1TextBottom;
        private string? _vinInformation2TextTop;
        private string? _vinInformation2TextBottom;

        public string? headertext
        {
            get => _headerText;
            set
            {
                _headerText = value;
                WhenPropertyChanged();
            }
        }

        public string? informationTextTop
        {
            get => _informationTextTop;
            set
            {
                _informationTextTop = value;
                WhenPropertyChanged();
            }
        }
        public string? informationTextCenter
        {
            get => _informationTextCenter;
            set
            {
                _informationTextCenter = value;
                WhenPropertyChanged();
            }
        }

        public string? informationTextBottom
        {
            get => _informationTextBottom;
            set
            {
                _informationTextBottom = value;
                WhenPropertyChanged();
            }
        }


        public string? markaText
        {
            get => _markaText;
            set
            {
                _markaText = value;
                WhenPropertyChanged();
            }
        }

        public string? modelText
        {
            get => _modelText;
            set
            {
                _modelText = value;
                WhenPropertyChanged();
            }
        }
        public string? banText
        {
            get => _banText;
            set
            {
                _banText = value;
                WhenPropertyChanged();
            }
        }
        public string? yurusText
        {
            get => _yurusText;
            set
            {
                _yurusText = value;
                WhenPropertyChanged();
            }
        }
        public string? rengText
        {
            get => _rengText;
            set
            {
                _rengText = value;
                WhenPropertyChanged();
            }
        }

        public string? qiymetText
        {
            get => _qiymetText;
            set
            {
                _qiymetText = value;
                WhenPropertyChanged();
            }
        }
        public string? sahibText
        {
            get => _sahibText;
            set
            {
                _sahibText = value;
                WhenPropertyChanged();
            }
        }

        public string? veziyyetText
        {
            get => _veziyyetText;
            set
            {
                _veziyyetText = value;
                WhenPropertyChanged();
            }
        }
        public string? yerlerText
        {
            get => _yerlerText;
            set
            {
                _yerlerText = value;
                WhenPropertyChanged();
            }
        }

        public string? vinKodText
        {
            get => _vinKodText;
            set
            {
                _vinKodText = value;
                WhenPropertyChanged();
            }
        }

        public string? vinKoduTapmaqText
        {
            get => _vinKoduTapmaqText;
            set
            {
                _vinKoduTapmaqText = value;
                WhenPropertyChanged();
            }
        }
        public string? elaveMelumatText
        {
            get => _elaveMelumatText;
            set
            {
                _elaveMelumatText = value;
                WhenPropertyChanged();
            }
        }

        public string? avtomobilinTehcizatiText
        {
            get => _avtomobilinTehcizatiText;
            set
            {
                _avtomobilinTehcizatiText = value;
                WhenPropertyChanged();
            }
        }

        //----------------------Avtomobil Tehcizati-------------------------
        public string? yungulDisktText
        {
            get => _yungulDisktText;
            set
            {
                _yungulDisktText = value;
                WhenPropertyChanged();
            }
        }
        public string? merkeziQapanmaText
        {
            get => _merkeziQapanmaText;
            set
            {
                _merkeziQapanmaText = value;
                WhenPropertyChanged();
            }
        }
        public string? deriSalonText
        {
            get => _deriSalonText;
            set
            {
                _deriSalonText = value;
                WhenPropertyChanged();
            }
        }
        public string? oturacaqlarinVentilyasiyasiText
        {
            get => _oturacaqlarinVentilyasiyasiText;
            set
            {
                _oturacaqlarinVentilyasiyasiText = value;
                WhenPropertyChanged();
            }
        }
        public string? absText
        {
            get => _absText;
            set
            {
                _absText = value;
                WhenPropertyChanged();
            }
        }
        public string? parkRadariText
        {
            get => _parkRadariText;
            set
            {
                _parkRadariText = value;
                WhenPropertyChanged();
            }
        }
        public string? ksenonLampalarText
        {
            get => _ksenonLampalarText;
            set
            {
                _ksenonLampalarText = value;
                WhenPropertyChanged();
            }
        }
        public string? lyukText
        {
            get => _lyukText;
            set
            {
                _lyukText = value;
                WhenPropertyChanged();
            }
        }
        public string? KondisionerText
        {
            get => _kondisionerText;
            set
            {
                _kondisionerText = value;
                WhenPropertyChanged();
            }
        }
        public string? kameraText
        {
            get => _kameraText;
            set
            {
                _kameraText = value;
                WhenPropertyChanged();
            }
        }
        public string? yagisSensoruText
        {
            get => _yagisSensoruText;
            set
            {
                _yagisSensoruText = value;
                WhenPropertyChanged();
            }
        }
        public string? oturacaqlarinIsidilmesiText
        {
            get => _oturacaqlarinIsidilmesiText;
            set
            {
                _oturacaqlarinIsidilmesiText = value;
                WhenPropertyChanged();
            }
        }
        public string? yanPerdelerText
        {
            get => _yanPerdelerText;
            set
            {
                _yanPerdelerText = value;
                WhenPropertyChanged();
            }
        }
        //------------------------------------------------------------------
        public string? sekillerText
        {
            get => _sekillerText;
            set
            {
                _sekillerText = value;
                WhenPropertyChanged();
            }
        }
        //--------------------Sekil Telebleri-------------------------------
        public string? teleb1TextTop
        {
            get => _teleb1TextTop;
            set
            {
                _teleb1TextTop = value;
                WhenPropertyChanged();
            }
        }
        public string? teleb1TextBottom
        {
            get => _teleb1TextBottom;
            set
            {
                _teleb1TextBottom = value;
                WhenPropertyChanged();
            }
        }
        public string? teleb2Text
        {
            get => _teleb2Text;
            set
            {
                _teleb2Text = value;
                WhenPropertyChanged();
            }
        }

        public string? teleb3Text
        {
            get => _teleb3Text; set
            {
                _teleb3Text = value;
                WhenPropertyChanged();
            }
        }
        //------------------------------------------------------------------
        public string? elaqeText
        {
            get => _elaqeText;
            set
            {
                _elaqeText = value;
            }
        }
        public string? elaqeInformationText
        {
            get => _elaqeInformationText;
            set
            {
                _elaqeInformationText = value;
                WhenPropertyChanged();
            }
        }
        //-------------------------------Elaqe------------------------------
        public string? nameText
        {
            get => _nameText;
            set
            {
                _nameText = value;
                WhenPropertyChanged();
            }
        }
        public string? seherText
        {
            get => _seherText;
            set
            {
                _seherText = value;
                WhenPropertyChanged();
            }
        }
        public string? emailText
        {
            get => _emailText;
            set
            {
                _emailText = value;
                WhenPropertyChanged();
            }
        }
        public string? telefonNomresiText
        {
            get => _telefonNomresiText;
            set
            {
                _telefonNomresiText = value;
                WhenPropertyChanged();
            }
        }
        //------------------------------------------------------------------

        public string? yanacaqText
        {
            get => _yanacaqText;
            set
            {
                _yanacaqText = value;
                WhenPropertyChanged();
            }
        }

        public string? oturucuText
        {
            get => _oturucuText;
            set
            {
                _oturucuText = value;
                WhenPropertyChanged();
            }
        }
        public string? suretlerQutusuText
        {
            get => _suretlerQutusuText;
            set
            {
                _suretlerQutusuText = value;
                WhenPropertyChanged();
            }
        }
        public string? ilText
        {
            get => _ilText;
            set
            {
                _ilText = value;
                WhenPropertyChanged();
            }
        }
        public string? muherrikinHecmiText
        {
            get => _muherrikinHecmiText;
            set
            {
                _muherrikinHecmiText = value;
                WhenPropertyChanged();
            }
        }

        public string? muherrikinGucu
        {
            get => _muherrikinGucu;
            set
            {
                _muherrikinGucu = value;
                WhenPropertyChanged();
            }
        }
        public string? hansiBazarUcunText
        {
            get => _hansiBazarUcunText;
            set
            {
                _hansiBazarUcunText = value;
                WhenPropertyChanged();
            }
        }

        //---------------------------Veziyyeti------------------------------------
        public string? vuruguVarTextTop
        {
            get => _vuruguVarTextTop;
            set
            {
                _vuruguVarTextTop = value;
                WhenPropertyChanged();
            }
        }
        public string? vuruguVarTextBottom
        {
            get => _vuruguVarTextBottom;
            set
            {
                _vuruguVarTextBottom = value;
                WhenPropertyChanged();
            }
        }

        public string? renglenibTextTop
        {
            get => _renglenibTextTop;
            set
            {
                _renglenibTextTop = value;
                WhenPropertyChanged();
            }
        }
        public string? renglenibTextBottom
        {
            get => _renglenibTextBottom;
            set
            {
                _renglenibTextBottom = value;
                WhenPropertyChanged();
            }
        }

        public string? qezaliTextTop
        {
            get => _qezaliTextTop;
            set
            {
                _qezaliTextTop = value;
                WhenPropertyChanged();
            }
        }

        public string? qezaliTextBottom
        {
            get => _qezaliTextBottom;
            set
            {
                _qezaliTextBottom = value;
                WhenPropertyChanged();
            }
        }

        //------------------------------------------------------------------------


        public string? qeydText
        {
            get => _qeydText;
            set
            {
                _qeydText = value;
                WhenPropertyChanged();
            }
        }

        public string? kreditText
        {
            get => _kreditText;
            set
            {
                _kreditText = value;
                WhenPropertyChanged();
            }
        }

        public string? barterText
        {
            get => _barterText;
            set
            {
                _barterText = value;
                WhenPropertyChanged();
            }
        }

        public string? davamEtText
        {
            get => _davamEtText;
            set
            {
                _davamEtText = value;
                WhenPropertyChanged();
            }
        }

        public string? razilasmaText
        {
            get => _razilasmaText;
            set
            {
                _razilasmaText = value;
                WhenPropertyChanged();
            }
        }


        //-----------------VIn kodu tapmaq--------------------------------


        public string? vinInformation1TextTop
        {
            get => _vinInformation1TextTop;
            set
            {
                _vinInformation1TextTop = value;
                WhenPropertyChanged();
            }
        }
        public string? vinInformation1TextBottom
        {
            get => _vinInformation1TextBottom;
            set
            {
                _vinInformation1TextBottom = value;
                WhenPropertyChanged();
            }
        }

        public string? vinInformation2TextTop
        {
            get => _vinInformation2TextTop;
            set
            {
                _vinInformation2TextTop = value;
                WhenPropertyChanged();
            }
        }

        public string? vinInformation2TextBottom
        {
            get => _vinInformation2TextBottom;
            set
            {
                _vinInformation2TextBottom = value;
                WhenPropertyChanged();
            }
        }

        //----------------------------------------------------------------





        public CreateNewVehicleViewModel(string? diltext)
        {
            if(diltext=="RU")
            {
                headertext = "Elan Yerləşdirmək";
                informationTextTop = "* Üç ay ərzində bir nəqliyyat vasitəsi yalnız bir dəfə pulsuz dərc oluna bilər.";
                informationTextCenter = "* Üç ay ərzində təkrar və ya oxşar elanlar (marka/model, rəng) ödənişlidir.";
                informationTextBottom = "* Elanınızı saytın ön sıralarında görmək üçün İrəli çək xidmətindən istifadə edin.";
                markaText = "Marka";
                yanacaqText = "Yanacaq növü";
                modelText = "Model";
                oturucuText = "Ötürücü";
                banText = "Ban növü";
                suretlerQutusuText = "Sürətlər qutusu";
                yurusText = "Yürüş";
                ilText = "İl";
                rengText = "Rəng";
                muherrikinHecmiText = "Mühərrikin həcmi";
                qiymetText = "Qiymət";
                muherrikinGucu = "Mühərrikin gücü, a.g";
                sahibText = "Neçənci sahibisiniz?";
                hansiBazarUcunText = "Hansı bazar üçün yığılıb";
                vinKodText = "VIN-kod";
                vinKoduTapmaqText = "VIN-kodu haradan tapmaq olar?";
                vinInformation1TextTop = "Nəqliyyat vasitəsinin texniki ";
                vinInformation1TextBottom = "passportun ön hissəsində";
                vinInformation2TextTop = "Yeni nəsil texniki passpostun";
                vinInformation2TextBottom = "arxa hissəsində";
                elaveMelumatText = "Əlavə məlumat";
                avtomobilinTehcizatiText = "Avtomobilin təchizatı";
                yungulDisktText = "Yüngül lehimli disklər";
                merkeziQapanmaText = "Mərkəzi qapanma";
                deriSalonText = "Dəri salon";
                oturacaqlarinVentilyasiyasiText = "Oturacaqların ventilyasiyası";
                absText = "ABS";
                parkRadariText = "Park radarı";
                ksenonLampalarText = "Ksenon lampalar";
                lyukText = "Lyuk";
                KondisionerText = "Kondisioner";
                kameraText = "Arxa görüntü kamerası";
                yagisSensoruText = "Yağış sensoru";
                oturacaqlarinIsidilmesiText = "Oturacaqların isidilməsi";
                yanPerdelerText = "Yan pərdələr";
                sekillerText = "Şəkillər";
                teleb1TextTop = "- Minimum – 1 şəkil (ön, arxa və bütöv ön";
                teleb1TextBottom = " panelin görüntüsü mütləqdir).";
                teleb2Text = "- Maksimum – 21 şəkil.";
                teleb3Text = "- Optimal ölçü – 1024x768 piksel.";
                elaqeText = "Əlaqə";
                elaqeInformationText = "Elan dərc olunduqdan sonra əlaqə məlumatları ilə bağlı heç bir dəyişiklik həyata keçirilmir.";
                nameText = "Adınız";
                seherText = "Şəhər";
                emailText = "E-mail";
                telefonNomresiText = "Telefon nömrəsi";
                davamEtText = "Yerləşdir";
                razilasmaText = "Elan yerləşdirərək, siz Turbo.az-ın İstifadəçi razılaşması və Qaydaları ilə razı olduğunuzu təsdiq edirsiniz";
            }
            else
            {
                headertext = "РАЗМЕСТИТЬ ОБЪЯВЛЕНИЕ";
                informationTextTop = "* В течение трёх месяцев один автомобиль можно выставлять на продажу бесплатно только один раз.";
                informationTextCenter = "* Размещение дублированных или похожих объявлений (марка/модель, цвет) в течение 3-х месяцев платное.";
                informationTextBottom = "* Чтобы ваше объявление оказалось на верхних позициях сайта, воспользуйтесь услугой \"Поднять в поиске\".";
                markaText = "Марка";
                yanacaqText = "Тип топлива";
                modelText = "Модель";
                oturucuText = "Привод ";
                banText = "Тип кузова ";
                suretlerQutusuText = "Коробка передач";
                yurusText = "Пробег";
                ilText = "Год";
                rengText = "Цвет";
                muherrikinHecmiText = "Объем двигателя";
                qiymetText = "Цена";
                muherrikinGucu = "Мощность, л.с.";
                sahibText = "Какой вы владелец?";
                hansiBazarUcunText = "Версия для рынка";
             
               
                
                vinKodText = "VIN";
                vinKoduTapmaqText = "Где найти VIN?";
                vinInformation1TextTop = "На лицевой стороне технического";
                vinInformation1TextBottom = "паспорта старого образца.";
                vinInformation2TextTop = "На обратной стороне технического ";
                vinInformation2TextBottom = "паспорта нового образца.";
                elaveMelumatText = "Описание";
                avtomobilinTehcizatiText = "Опции";
                yungulDisktText = "Литые диски";
                merkeziQapanmaText = "Центральный замок";
                deriSalonText = "Кожаный салон";
                oturacaqlarinVentilyasiyasiText = "Вентиляция сидений";
                absText = "ABS";
                parkRadariText = "Парктроник";
                ksenonLampalarText = "Ксенон";
                lyukText = "Люк";
                KondisionerText = "Кондиционер";
                kameraText = "Камера заднего вида";
                yagisSensoruText = "Датчик дождя";
                oturacaqlarinIsidilmesiText = "Подогрев сидений";
                yanPerdelerText = "Боковые шторки";
                sekillerText = "Фотографии";
                teleb1TextTop = "- Минимум – 3 фото (вид спереди, вид";
                teleb1TextBottom = "сзади, полностью передняя панель).";
                teleb2Text = "- Максимум – 21 фото.";
                teleb3Text = "- Оптимальный размер – 1024x768 пикселей.";
                elaqeText = "Контакты";
                elaqeInformationText = "После публикации объявления контактная информация редактированию не подлежит.";
                nameText = "Имя";
                seherText = "Город ";
                emailText = "E-mail";
                telefonNomresiText = "Телефон";
                davamEtText = "Разместить";
                razilasmaText = "Размещая объявление, вы подтверждаете согласие с Пользовательским соглашением и Правилами Turbo.az";
            }
        }




        // ->> InotifyFunction <<-- //

        public event PropertyChangedEventHandler? PropertyChanged;

        public void WhenPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
