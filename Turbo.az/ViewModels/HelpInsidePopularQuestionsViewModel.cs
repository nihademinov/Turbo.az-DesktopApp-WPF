using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az_Desktop_App.ViewModels
{
    class HelpInsidePopularQuestionsViewModel
    {

        private string? _esasSeifeText;
        private string? _yardimText;
        private string? _elanText;


        public string? esasSeifeText
        {
            get => _esasSeifeText; set
            {
                _esasSeifeText = value;
                WhenPropertyChanged();
            }
        }
        public string? yardimText
        {
            get => _yardimText; set
            {
                _yardimText = value;
                WhenPropertyChanged();
            }
        }
        public string? elanText
        {
            get => _elanText; set
            {
                _elanText = value;
                WhenPropertyChanged();
            }
        }

        //-----------------------------------------------------Elanim Niye derc olunmadi Hisssesi

        public string? elanimNiyeDercOlunmadiText { get; set; }
        public string? dercText1 { get; set; }
        public string? dercText2 { get; set; }
        public string? dercText3 { get; set; }
        public string? dercText4 { get; set; }
        public string? dercText5 { get; set; }
        public string? dercText6 { get; set; }
        public string? dercText7 { get; set; }
        public string? dercText8 { get; set; }
        public string? dercText9 { get; set; }
        //----------------------------------------------------Elana nece duzelis edim hissesi
        public string? elanaNeceDuzelisEdimText { get; set; }

        public string? duzelistext1 { get; set; }
        public string? duzelistext2 { get; set; }
        public string? duzelistext3 { get; set; }
        public string? duzelistext4 { get; set; }
        public string? duzelistext5 { get; set; }
        public string? duzelistext6 { get; set; }
        public string? duzelistext7 { get; set; }
        public string? duzelistext8 { get; set; }
        public string? duzelistext9 { get; set; }
        public string? duzelistext10 { get; set; }
        public string? duzelistext11 { get; set; }
        public string? duzelistext12 { get; set; }
        public string? duzelistext13 { get; set; }
        public string? duzelistext14 { get; set; }
        public string? duzelistext15 { get; set; }
        public string? duzelistext16 { get; set; }
        public string? duzelistext17 { get; set; }
        public string? duzelistext18 { get; set; }

        //----------------------------------------------------Elani nece yerlesdirim hissesi
        public string? elaniNeceYerlesdirimText { get; set; }
        public string? yerlesdirmekText1 { get; set; }
        public string? yerlesdirmekText2 { get; set; }
        public string? yerlesdirmekText3 { get; set; }
        public string? yerlesdirmekText4 { get; set; }
        public string? yerlesdirmekText5 { get; set; }
        public string? yerlesdirmekText6 { get; set; }
        public string? yerlesdirmekText7 { get; set; }
        public string? yerlesdirmekText8 { get; set; }
        public string? yerlesdirmekText9 { get; set; }
        public string? yerlesdirmekText10 { get; set; }
        public string? yerlesdirmekText11 { get; set; }
        public string? yerlesdirmekText12 { get; set; }
        public string? yerlesdirmekText13 { get; set; }


        //----------------------------------------------------Elani nece silim hissesi

        public string? elaniNeceSilimText { get; set; }
        public string? silmekText1 { get; set; }
        public string? silmekText2 { get; set; }
        public string? silmekText3 { get; set; }
        public string? silmekText4 { get; set; }
        public string? silmekText5 { get; set; }
        public string? silmekText6 { get; set; }
        public string? silmekText7 { get; set; }
        public string? silmekText8 { get; set; }
        public string? silmekText9 { get; set; }
        public string? silmekText10 { get; set; }
        public string? silmekText11 { get; set; }
        public string? silmekText12 { get; set; }
        public string? silmekText13 { get; set; }
        public string? silmekText14 { get; set; }

        //-----------------------------------------------------------------------------


        public HelpInsidePopularQuestionsViewModel(string? diltext)
        {
            if(diltext == "RU")
            {
                esasSeifeText = "Əsas səhifə";
                yardimText = "Yardım";
                elanText = "Populyar suallar";

                elanimNiyeDercOlunmadiText = "Elanım niyə dərc olunmadı?";
                dercText1 = "Çox güman ki, siz elan yerləşdirmə Qaydalarından hər hansısa birinə və ya bir";
                dercText2 = "neçəsinə əməl etməmisiniz.";
                dercText3 = "Səbəb daha ətraflı şəkildə elanı yerləşdirərkən qeyd etdiyiniz email ünvanına";
                dercText4 = "göndərilib.";
                dercText5 = "Həmçinin elanın dərc olunmama səbəbi ilə";
                dercText6 = "saytın tam (desktop) versiyasında Şəxsi kabinetdəki 'Mənim elanlarım' > 'İmtina";
                dercText7 = "olunmuş' bölməsində";
                dercText8 = "saytın mobil versiyasında Şəxsi kabinetdəki 'İmtina olunmuş' bölməsində;";
                dercText9 = "tətbiqdə isə Şəxsi kabinetdəki 'İmtina olunmuş' bölməsində tanış ola bilərsiniz.";

                elanaNeceDuzelisEdimText = "Elana necə düzəliş edim?";
                duzelistext1 = "Şəxsi kabinetdə düzəliş üçün:";
                duzelistext2 = "1. Şəxsi kabinetə daxil olun.";
                duzelistext3 = "2. Saytın tam versiyasındasınızsa,'Mənim elanlarım' səhifəsini açın, mobil";
                duzelistext4 = "versiyada və ya tətbiqdəsinizsə, növbəti addıma keçin.";
                duzelistext5 = "3. Saytın tam və ya mobil versiyasında 'Saytda' bölməsini, tətbiqdə isə 'Hazırda";
                duzelistext6 = "saytda' bölməsini seçin.";
                duzelistext7 = "4. Düzəliş etmək istədiyiniz elanın aşağısında Düzəliş et düyməsini";
                duzelistext8 = "görəcəksiniz. Onu sıxın.";
                duzelistext9 = "5. Lazım olan düzəlişləri etdikdən sonra Elanı yenilə düyməsini sıxın.";
                duzelistext10 = "Elanınızın öz səhifəsində düzəliş üçün:";
                duzelistext11 = "1. Düzəliş etmək istədiyiniz elanınızı saytda tapın və açın.";
                duzelistext12 = "2. Elan səhifəsinin aşağısında Düzəliş et düyməsini görəcəksiniz. Onu sıxın.";
                duzelistext13 = "3. Elan yerləşdirilən zaman sizə göndərilən PIN-kodu daxil edin və redaktəyə başlayın.";
                duzelistext14 = "4. Lazım olan düzəlişləri etdikdən sonra Elanı yenilə düyməsini sıxın.";
                duzelistext15 = "Kateqoriyadan asılı olaraq siz qiyməti və təsviri dəyişə, şəkilləri silə və ya əlavə edə";
                duzelistext16 = "və digər düzəlişlər edə bilərsiniz.";
                duzelistext17 = "çəkə bilər, lakin adətən düzəlişlər bir neçə dəqiqədən sonra tətbiq olunur.";
                duzelistext18 = "Unutmayın ki, 24 saat ərzində bir elana yalnız 2 dəfə düzəliş edə bilərsiniz.";



                elaniNeceYerlesdirimText = "Elanı necə yerləşdirim?";

                yerlesdirmekText1 = "Siz elanı Turbo.az saytının tam (desktop) və ya mobil versiyasında, eləcə də mobil";
                yerlesdirmekText2 = "tətbiqdə yerləşdirə bilərsiniz.";
                yerlesdirmekText3 = "Saytın tam və ya mobil versiyasında elan yerləşdirmək üçün:";
                yerlesdirmekText4 = "1. Tam versiyada yuxarı sağ küncdəki Yeni elan düyməsini, mobil versiyada isə";
                yerlesdirmekText5 = "ekranın aşağısındakı Yeni elan və ya yuxarı sağ küncdəki + düyməsini sıxın.";
                yerlesdirmekText6 = "2. Açılan səhifədə xanaları dolduraraq nəqliyyat vasitəsi barədə məlumatları";
                yerlesdirmekText7 = "qeyd edin. Nəzərə alın ki, bu məlumatları potensial alıcılar oxuyacaq.";
                yerlesdirmekText8 = "3. Elanı Şəxsi kabinetinizdən yerləşdirirsinizsə, Əlaqə məlumatları hissəsində";
                yerlesdirmekText9 = "profiliniz üçün təsdiqlənmiş telefon nömrəsi müvafiq xanaya doldurulacaq.";
                yerlesdirmekText10 = "4. Əgər elanı Şəxsi kabinetə daxil olmadan yerləşdirirsinizsə, onun yoxlamaya";
                yerlesdirmekText11 = "göndərilməsi üçün Əlaqə məlumatları hissəsində qeyd etdiyiniz e-mail";
                yerlesdirmekText12 = "ünvanınızı təsdiqləməlisiniz.";
                yerlesdirmekText13 = "5. Demək olar ki, hazırdır! Sadəcə Elan yerləşdir düyməsini sıxmaq qalır";


                elaniNeceSilimText = "Elanı necə silim?";
                silmekText1 = "Şəxsi kabinetdə silmək üçün:";
                silmekText2 = "1. Şəxsi kabinetə daxil olun.";
                silmekText3 = "2. Saytın tam versiyasındasınızsa,'Mənim elanlarım' səhifəsini açın, mobil";
                silmekText4 = "versiyada və ya tətbiqdəsinizsə, növbəti addıma keçin.";
                silmekText5 = "3. Saytın tam və ya mobil versiyasında 'Saytda' bölməsini, tətbiqdə isə 'Hazırda";
                silmekText6 = "saytda' bölməsini seçin.";
                silmekText7 = "4. Silmək istədiyiniz elanın aşağısında Elanı sil düyməsini görəcəksiniz. Onu sıxın.";
                silmekText8 = "Elanınızın öz səhifəsində silmək üçün:";
                silmekText9 = "1. Silmək etmək istədiyiniz elanınızı saytda tapın və açın.";
                silmekText10 = "2.Elan yerləşdirilən zaman sizə göndərilən PIN-kodu daxil edin və təsdiq edin.";
                silmekText11 = "3. Elan səhifəsinin aşağısında Elanı sil düyməsini görəcəksiniz. Onu sıxın.";
                silmekText12 = "Silindikdən sonra elanınız 'Saytda' (tətbiqdə Hazırda saytda) statusundan";
                silmekText13 = "Müddəti başa çatmış statusuna keçiriləcək və onu istənilən vaxt ödənişli şəkildə";
                silmekText14 = "bərpa etmək mümkün olacaq.";
            }
            else
            {
                esasSeifeText = "Главная";
                yardimText = "Помощь";
                elanText = "Популярные вопросы";

                elanimNiyeDercOlunmadiText = "Почему отклонили моё объявление?";
                dercText1 = "Скорее всего, вы не следовали какому-либо одному или нескольким";
                dercText2 = "Правилам размещения объявлений.";
                dercText3 = "Более подробная информация о причине была отправлена на email-адрес,";
                dercText4 = "указанный вами при размещении объявления.";
                dercText5 = "Кроме того, с причиной отклонения объявления можно ознакомиться";
                dercText6 = "в полной (десктоп) версии сайта: в Личном кабинете – в разделе «Мои";
                dercText7 = "объявления» > «Отклоненные»;";
                dercText8 = "в мобильной версии сайта и приложении: в Личном кабинете – в разделе";
                dercText9 = "«Отклоненные».";

                elanaNeceDuzelisEdimText = "Как отредактировать объявление?";
                duzelistext1 = "Для редактирования в Личном кабинете:";
                duzelistext2 = "1. Войдите в личный кабинет.";
                duzelistext3 = "2. Если вы находитесь на полной версии сайта, откройте страницу «Мои";
                duzelistext4 = "объявления», если в мобильной версии или приложении – перейдите к";
                duzelistext5 = " следующему шагу.";
                duzelistext6 = "3. Выберите вкладку «На сайте».";
                duzelistext7 = "4. Под объявлением, в которое вы хотите внести изменения, увидите";
                duzelistext8 = "кнопку Редактировать. Нажмите её.";
                duzelistext9 = "5. После внесения необходимых изменений нажмите кнопку Сохранить объявление.";
                duzelistext10 = "Для редактирования на странице своего объявления:";
                duzelistext11 = "1. Для редактирования на странице своего объявления и откройте его:";
                duzelistext12 = "2. Внизу страницы объявления вы увидите кнопку Редактировать.";
                duzelistext13 = "3. Введите PIN-код, отправленный вам при публикации объявления,и начните редактирование.";
                duzelistext14 = "4. После внесения необходимых изменений нажмите кнопку Сохранить объявление.";
                duzelistext15 = "В зависимости от категории вы можете поменять цену и описание,удалить или добавить фото";
                duzelistext16 = "После внесения изменений ваше объявление будет отправлено на проверку. ";
                duzelistext17 = "Проверка может занять до 1 часа, но обычно изменения применяются уже спустя пару минут.";
                duzelistext18 = "Имейте в виду, что в течение 24 часов вы можете редактировать объявление только 2 раза.";



                elaniNeceYerlesdirimText = "Как разместить объявление?";

                yerlesdirmekText1 = "Разместить объявление можно как в полной (десктоп) или мобильной версии";
                yerlesdirmekText2 = "сайта Turbo.az, так и в мобильном приложении.";
                yerlesdirmekText3 = "Размещение в полной или мобильной версии сайта:";
                yerlesdirmekText4 = "1. В полной версии нажмите кнопку Добавить объявление в правом верхнем углу страницы,";
                yerlesdirmekText5 = "а в мобильной версии кнопку Продать в нижней части экрана или + в правом верхнем углу.";
                yerlesdirmekText6 = "2. На открывшейся странице напишите информацию о транспортном";
                yerlesdirmekText7 = "средстве, заполнив ячейки.";
                yerlesdirmekText8 = "3. Если вы размещаете объявление с Личного кабинета, то в разделе";
                yerlesdirmekText9 = "Контактных данных соответствующее поле автоматически заполнится номером телефона.";
                yerlesdirmekText10 = "4. Если вы размещаете объявление без входа в Личный кабинет, то для его";
                yerlesdirmekText11 = "отправки на проверку необходимо подтвердить номер телефона,";
                yerlesdirmekText12 = "который вы указали в разделе Контактных данных.";
                yerlesdirmekText13 = "5.Почти готово! Остается только нажать на кнопку Создать объявление:";


                elaniNeceSilimText = "Как удалить объявление?";
                silmekText1 = "Удаление в Личном кабинете:";
                silmekText2 = "1. Войдите в личный кабинет.";
                silmekText3 = "2. Если вы находитесь на полной версии сайта, откройте страницу «Мои";
                silmekText4 = "объявления», если в мобильной версии или приложении – перейдите";
                silmekText5 = "к следующему шагу.";
                silmekText6 = "3. Выберите вкладку «На сайте».";
                silmekText7 = "4. Под объявлением, которого вы хотите удалить, увидите кнопку Удалить. Нажмите её.";
                silmekText8 = "Удаление на странице своего объявления:";
                silmekText9 = "1. Найдите на сайте свое объявление, которое хотите удалить, и откройте его.";
                silmekText10 = "2.Введите PIN-код, отправленный вам при размещении объявления, и подтвердите.";
                silmekText11 = "3. Внизу страницы объявления вы увидите кнопку Удалить. Нажмите её.";
                silmekText12 = "После успешного удаления ваше объявление поменяет свой статус из «На";
                silmekText13 = "сайте» на «Истекшие» и восстановить его можно будет в любое время на";
                silmekText14 = "платной основе.";
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
