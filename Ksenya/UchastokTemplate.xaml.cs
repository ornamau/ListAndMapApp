﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ksenya
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UchastokTemplate : ContentPage
    {
        public UchastokTemplate(int id)
        {
            Image image = new Image();

            Label title = new Label();
            title.FontAttributes = FontAttributes.Bold;
            title.FontSize = 16;
            title.HorizontalOptions = LayoutOptions.Center;

            Label text = new Label();
            text.FontSize = 14;
            text.FontAttributes = FontAttributes.Bold;
            text.HorizontalOptions = LayoutOptions.Center;
            text.HorizontalTextAlignment = TextAlignment.Center;

            switch (id)
            {
                case 16:
                    title.Text = "Избирательный участок № 39-16";
                    image.Source = ImageSource.FromResource("Ksenya.3916.jpg");
                    text.Text = $"Станица Павловская, административное здание ООО «Югстрой», \n ул.Преградная, 2а. \n тел. 5 - 19 - 51. \n \n Территория станицы Павловской в границах: \nПреградная(все дома); \nМостовая(все дома); \nСадовая(все дома); \nХалтурина(четная - все дома); \nПушкина(нечетная) с 465 по 469; \nЮных Ленинцев(нечетная) с 461 по 489; \nЮных Ленинцев(четная) с 436 по 456; \n Крупской(нечетная) с 461 по 507; \nКрупской(четная) с 444 по 490; \nОктябрьская(нечетная) с 439 по 481; \nОктябрьская(четная) с 430 по 466; \nНабережная(четная) с 288 по 324; \n Набережная(нечетная) с 309 по 323. \n";
                    break;
                case 17:
                    title.Text = "Избирательный участок № 39-17";
                    image.Source = ImageSource.FromResource("Ksenya.3917.jpg");
                    text.Text = $"Станица Павловская, клуб закрытого акционерного общества “Колос”,\nул. Горького, 354.\nтел. 5-18-71.\nТерритория станицы Павловской в границах:\n Юных Ленинцев(четная) с 288 по 434;\nПушкина(нечетная) с 319 по 463;\nПушкина(четная) с 354 по 490;\nГорького(нечетная) с 375 по 519;\nГорького(четная) с 330 по 480;\nБазарная(нечетная) с 317 по 435;\nБазарная(четная) с 280 по 384;\nЖлобы(нечетная) с 255 по 393;\nЖлобы(четная) с 180 по 208;\nЭнгельса(четная) со 2 по 54;\nЭнгельса(нечетная) с 1 по 35;\nПролетарская(четная) со 2 по 30;\nКарла Маркса(нечетная) с 1по 45;\nКарла Маркса(четная) со 2 по 56;\nБольшевистская(четная) со 2 по 16;\nБольшевистская(нечетная) с 1 по 21;\nКомсомольская(четная) со 2 по 8;\nКомсомольская(нечетная) с 1 по 15;\nПроезжая(нечетная) с 89 по 105;\nЛермонтова(четная) со 2 по 14;\nЛермонтова(нечетная) с 1 по 13;\nХалтурина(нечетная) с 1 по 7.\n";
                    break;
                case 18:
                    title.Text = "Избирательный участок № 39-18";
                    image.Source = ImageSource.FromResource("Ksenya.3918.jpg");
                    text.Text = $"Станица Павловская, средняя общеобразовательная школа № 10,\nул. Комсомольская, 17.\nтел. 5-17-22.\nТерритория станицы Павловской в границах:\nХалтурина(нечетная) с 9 по 81;\nЮных Ленинцев(нечетная) с 323 по 459;\nЭнгельса(четная) с 56 по 76;\nГвардейская(все дома);\nКарла Маркса(нечетная) с 47 по 79;\nКарла Маркса(четная) с 58 по 86;\nКомсомольская(четная) с 10 по 78;\nКомсомольская(нечетная) с 19 по 75;\nНабережная(нечетная) с 153 по 307;\nНабережная(четная) с 162 по 286а;\nКрупской(нечетная) с 323 по 459;\nКрупской(четная) с 312 по 442;\nЛукьяненко(все дома);\nЛермонтова(нечетная) с 15 по 45;\nЛермонтова(четная) с 16 по 52;\nБольшевистская(четная) с 18 по 74;\nБольшевистская(нечетная) с 23 по 89;\nОктябрьская(нечетная) с 297 по 437;\nОктябрьская(четная) с 292 по 428.";
                        break;
                case 19:
                    title.Text = "Избирательный участок № 39-19";
                    image.Source = ImageSource.FromResource("Ksenya.3919.jpg");
                    text.Text = $"Станица Павловская, Дворец культуры, ул. Крупской, 237.\nтел. 3-11-52.\nТерритория станицы Павловской в границах:\nРабочая (четная) со 102 по 132;\nКалинина (нечетная) с 67 по 117;\nКалинина (четная) с 84 по 104;\nГладкова (нечетная) с 47 по 79;\nГладкова (четная) с 42 по 64;\nЛенина (четная) с 38 по 58;\nЛенина (нечетная) с 31 по 49;\nПролетарская (четная) с 60 по 96;\nПролетарская (нечетная) с 59 по 87;\nПервомайская (четная) с 36 по 58;\nПервомайская (нечетная) с 35 по 57;\nКирова (нечетная) с 27 по 49;\nКирова (четная) с 46 по 76;\nЭнгельса (нечетная) с 59 по 87;\nЮных Ленинцев (нечетная) с 185 по 321;\nКрупской (четная) со 184 по 310;\nКрупской (нечетная) с 139 по 321;\nОктябрьская (четная) со 108 по 290;\nОктябрьская (нечетная) со 113 по 295;\nНабережная (четная) с 72 по 160;\nНабережная (нечетная) с 97 по 151;\nУрицкого (нечетная) со 103 по 127;\nУрицкого (четная) с 86 по 112;\nКрупской, 7-й квартал №№ 1-10.";
                    break;
                case 20:
                    title.Text = "Избирательный участок № 39-20";
                    image.Source = ImageSource.FromResource("Ksenya.3920.jpg");
                    text.Text = $"Станица Павловская, школа искусств, ул. Горького, 302.\nтел. 5-41-86.\nТерритория станицы Павловской в границах:\nПроезжая (нечетная) с 43 по 87;\nЖлобы (четная) 178 (один дом);\nЖлобы (нечетная) с 233 по 253;\nБазарная (четная) с 264 по 278;\nБазарная (нечетная) с 293 по 315;\nГорького (четная) с 306 по 328;\nГорького (нечетная) с 289 по 373;\nПушкина (четная) с 262 по 352;\nПушкина (нечетная) с 247 по 317;\nЮных Ленинцев (четная) с 220 по 286;\nЛенина (четная) со 2 по 36;\nПервомайская (нечетная) с 7 по 33;\nПервомайская (четная) со 2 по 32;\nКирова (нечетная) с 1 по 25;\nКирова (четная) с 4 по 44;\nПролетарская (нечетная) с 1 по 57;\nПролетарская (четная) с 32 по 58а;\nЭнгельса (нечетная) с 37 по 57.";
                    break;
                case 21:
                    title.Text = "Избирательный участок № 39-21";
                    image.Source = ImageSource.FromResource("Ksenya.3921.jpg");
                    text.Text = $"Станица Павловская, центр дополнительного образования для детей № 1,\nул. Ленина, 13.\nтел. 5-32-45.\nТерритория станицы Павловской в границах:\nЮных Ленинцев, 7 квартал, №№ 1-54;\nЮных Ленинцев (четная) с 156 по 218;\nПушкина (четная) с 196 по 256;\nПушкина (нечетная) с 171 по 243;\nГорького (четная) с 252 по 288;\nГорького (нечетная) с 241 по 277;\nБазарная (четная) с 242 по 260;\nБазарная (нечетная) с 259 по 291;\nЖлобы (четная) со 150 по 176;\nЖлобы (нечетная) с 217 по 229;\nПроезжая (нечетная) с 31 по 41;\nПроезжая (четная) 4 (один дом);\nЛенина (нечетная) с 1 по 5;\nГладкова (четная) со 2 по 40;\nГладкова (нечетная) с 9 по 43;\nНовопочтовая (все дома);\nКалинина (четная) со 2 по 80;\nКалинина (нечетная) с 1 по 65;\nРабочая (четная) со 2 по 100.";
                    break;
                case 22:
                    title.Text = "Избирательный участок № 39-22";
                    image.Source = ImageSource.FromResource("Ksenya.3922.jpg");
                    text.Text = $"Станица Павловская, здание Павловской автостанции,\nул. Чкалова, 3.\nтел.  5-12-50.\nТерритория станицы Павловской в границах:\nАзовская (четная) со 2 по 24;\nРеволюционная (нечетная) с 1 по 29;\nРеволюционная (четная) со 2 по 8;\nКрестьянская (нечетная) с 1 по 31;\nКрестьянская (четная) со 2 по 32;\nШевченко (нечетная) с 1 по 33;\nШевченко (четная) со 2 по 26;\nКоминтерна (нечетная) с 1 по 25;\nКоминтерна (четная) со 2 по 28;\nКороткая (нечетная) с 1 по 35;\nКороткая (четная) со 2 по 70;\nРабочая (нечетная) с 1 по 87;\nТолстого (нечетная) с 31 по 135;\nТолстого (четная) со 2 по 58;\nЖлобы (нечетная) с 1 по 215;\nЖлобы (четная) со 2 по 148;\nБазарная (нечетная) с 51 по 255;\nБазарная (четная) 48, с 58 по 240а;\nГорького (четная) с 52 по 250;\n8-го Марта (все дома);\nОлимпийская (все дома);\nСпортивная (нечетная) с 1 по 17;\nСпортивная (четная) со 2 по 26;\nЧкалова (нечетная) с 1 по 35;\nЧкалова (четная) со 2 по 68;\nФестивальная (все дома);\nПроезжая (нечетная) с 1 по 29.\nПереулки:\nКоммунальный(все дома);\nГаражный(все дома);\nДальний 3,7(два дома);\nКирпичный завод(все дома).";
                    break;
                case 23:
                    title.Text = "Избирательный участок № 39-23";
                    image.Source = ImageSource.FromResource("Ksenya.3923.jpg");
                    text.Text = $"Станица Павловская, средняя общеобразовательная школа № 3,\nул. Шевченко, 36.\nтел. 5-32-34.\nТерритория станицы Павловской в границах:\nРабочая (нечетная) с 89 по 159;\nПушкина (нечетная) со 119 по 169;\nПушкина (четная) со 128 по 194;\nЮных ленинцев (нечетная) со 125 по 183а;\nЮных ленинцев (четная) со 122 по 154;\nКрупской (нечетная) с 1 по 137;\nКрупской (четная) со 116 по 182;\nОктябрьская (четная) со 2 по 106;\nОктябрьская (нечетная) с 1 по 111;\nУрицкого (четная) со 2 по 84-а;\nУрицкого (нечетная) с 1 по 101а;\nНабережная (четная) со 2 по 70;\nНабережная (нечетная) с 1 по 95;\nГорького (нечетная) с 157 по 239;\nКороткая (четная) с 70а по 88;\nКороткая (нечетная) с 37 по 57;\nКоминтерна (четная) с 30 по 114;\nКоминтерна (нечетная) с 25-а по 87;\nШевченко (четная) с 28 по 70;\nШевченко (нечетная) с 81 по 105;\nСолнечная (все дома);\nКооперативная (все дома);\nКондратюка (все дома);\nБратская (все дома);\nПащенко (все дома);\nКрасноармейская (все дома);\nДружбы (все дома);\nАзовская (четная) с 94 по 108;\nРеволюционная (четная) с 72 по 110;\nРеволюционная (нечетная) с 97 по 117;\nКрестьянская (четная) с 92 по 102;\nКрестьянская (нечетная) со 113 по 165.";
                    break;
                case 24:
                    title.Text = "Избирательный участок № 39-24";
                    image.Source = ImageSource.FromResource("Ksenya.3924.jpg");
                    text.Text = $"Станица Павловская, муниципальное унитарное предприятие учебно-курсовой комбинат «Павловский», ул. Шевченко, 47а.\nтел. 3-13-41.\nТерритория станицы Павловской в границах:\nГорького (нечетная) с 1 по 155;\nГорького (четная) со 2 по 48;\nБазарная (четная) со 2 по 56;\nБазарная (нечетная) с 1 по 49;\nТолстого (нечетная) с 1 по 29;\nПушкина (четная) со 2 по 126;\nПушкина (нечетная) с 1 по 117;\nЮных Ленинцев (четная) со 2 по 118;\nЮных Ленинцев (нечетная) с 1 по 123;\nКрупской (четная) со 2 по 114;\nАзовская (нечетная) с 1 по 87;\nАзовская (четная) с 26 по 92;\nРеволюционная (четная) с 10 по 70;\nРеволюционная (нечетная) с 31 по 95;\nКрестьянская (четная) с 34 по 90;\nКрестьянская (нечетная) с 33 по 111;\nШевченко (нечетная) с 37 по 79;\nНовая (все дома);\nПарковая (все дома);\nПобеды (все дома);\nРоссийская (все дома);\nНародная (все дома);\nКраснодарская (четная);\nШкольная (все дома);\nПартизанская (все дома);\nКазачья (все дома);\nПетра Слюсарева (все дома);\nСельская (все дома);\nПереулки:\nЦентральный (все дома);\nСвободный (все дома).";
                    break;
                case 25:
                    title.Text = "Избирательный участок № 39-25";
                    image.Source = ImageSource.FromResource("Ksenya.3925.jpg");
                    text.Text = $"Станица Павловская, административное здание                                                       ООО «Агрокомплекс Павловский», ул. Спартаковская, 1.\nтел. 3-25-00.\nТерритория станицы Павловской в границах:\n1-я Пионерская (все дома);\n2-я Пионерская (все дома);\nГражданская (нечетная) с 1 по 107;\nЗеленая (все дома);\nКалинина (нечетная) с 141 по 159;\nКалинина (четная) со 112 по 116, 120;\nКирова (четная) 94, 96 (два дома);\nКрасная (все дома);\nКоминтерна (нечетная) 89, 93;\nКоминтерна (четная) с 118 по 122;\nПервомайская (нечетная) 75, 77, 79 (три дома);\nПролетарская (нечетная) 103,105 (два дома);\nПролетарская (четная) со 112 по 118;\nСвердлова (все дома);\nЭнгельса (нечетная) со 107 по 111;\nЭнгельса (четная) с 88 по 116;\nАбрикосовая (все дома).\nпер. Радужный (все дома).";
                    break;
                case 26:
                    title.Text = "Избирательный участок № 39-26";
                    image.Source = ImageSource.FromResource("Ksenya.3926.jpg");
                    text.Text = $"Станица Павловская, здание столовой ООО «Агрокомплекс Павловский»,\nул. Гражданская, 23.\nтел. 4-18-41.\nТерритория станицы Павловской в границах:\nЗаречная (все дома);\nСпартаковская (все дома);\nКарла Маркса (нечетная) с 81 по 85;\nБереговая (все дома);\nКалинина (нечетная) со 119 по 139;\nКалинина (четная) со 106 по110;\nГражданская (четная) со 2 по 90;\nЛенина (нечетная) с 51 по 57, 69;\nЛенина (четная) с 62 по 84;\nПервомайская (нечетная) с 57а по 73;\nПервомайская (четная) с 60 по 76;\nКирова (нечетная) с 51 по 67;\nКирова (четная) с 78 по 92;\nПролетарская (нечетная) с 89 по 105;\nПролетарская (четная) с 96а по 110;\nЭнгельса (нечетная) с 91 по 105;\nЭнгельса (четная) с 78 по 84, 92 и 106;\nЛермонтова (нечетная) с 53 по 57;\nЛермонтова (четная) с 52а по 62.\nСадовое товарищество «Строитель» улицы:\nЗеленая 127а;\nЦветочная 108, 119;\nОреховая, 87;\nМалиновая (все дома);\nМирная 19;\nСадовая 6, 7;\nСолнечная (все дома).\nСадовое товарищество «Кооператор» улицы:\nВишневая 187, 198, 202;\nКлубничная 161;\nПрохладная 8, 9, 18, 20, 26, 27, 28;\nРозовая 125, 136;\nСиреневая 41, 76, 87, 91.\nПереулки:\nБезымянный (все дома);\nСпартаковский (все дома).\n";
                    break;
                case 27:
                    title.Text = "Избирательный участок № 39-27";
                    image.Source = ImageSource.FromResource("Ksenya.3927.jpg");
                    text.Text = $"Станица Павловская, административное здание ООО «Ника»,\nул. Промышленная 26/1.\nтел. 5-14-55.\nТерритория станицы Павловской в границах:\nДзержинского (все дома);\nЗападная (все дома);\nКосмическая (все дома);\nКубанская (все дома);\nКуйбышева (все дома);\nЛенинградская 1-4,14;\nМосковская (все дома);\nПромышленная (четная) 8-40;\nСоветская (нечетная) 1-59.";
                    break;
                case 28:
                    title.Text = "Избирательный участок № 39-28";
                    image.Source = ImageSource.FromResource("Ksenya.3928.jpg");
                    text.Text = $"Станица Павловская, средняя общеобразовательная школа № 1,\nул. Заводская, 30.\nтел. 5-20-79.\nТерритория станицы Павловской в границах:\nСоветская (четная) 2-62;\nМолодежная 1,8;\nЗаводская (все дома);\nМира (все дома);\nЩорса (все дома);\nВорошилова (все дома);\nХлебная 2а.\n";
                    break;
                case 29:
                    title.Text = "Избирательный участок № 39-29";
                    image.Source = ImageSource.FromResource("Ksenya.3929.jpg");
                    text.Text = $"Станица Павловская, административное здание индивидуального предпринимателя Савранского В. П., ул. Советская, 66.\nтел. 5-17-34.\nСтаница Павловская, магазин «Бриз», ул. Советская, 72   тел. 5-26-88. (старая информация).\nТерритория станицы Павловской в границах:\nВишневая (все дома);\nГоголя (все дома);\nКочубея (нечетная);\nКурчатова (все дома);\nВокзальная (все дома);\nЛуначарского (четная) 2-12;\nМаяковского (все дома);\nСоветская (нечетная) 77-159;\nЧапаева (все дома);\nЮбилейная (все дома);\nЮжная (все дома);\nТимирязева (все дома);\nЛесная (все дома);\nОсенняя (все дома);\nТенистая (все дома);\nРаздольная (нечетная).\nПереулки:\nИзумрудный (все дома);\nЛетний (все дома).\n";
                    break;
                case 30:
                    title.Text = "Избирательный участок № 39-30";
                    image.Source = ImageSource.FromResource("Ksenya.3930.jpg");
                    text.Text = $"Станица Павловская, железнодорожный вокзал Сосыка-Ростовская,\nул. Вокзальная.\nтел. 5-40-82.\nТерритория поселка Сосыка:\nЖелезнодорожная (все дома);\nБогдана Хмельницкого (все дома);\nСтепная (все дома);\nПолевая (все дома);\nЛуговая (все дома);\nПутевая (все дома);\nСветлая (все дома);\nСодружества (все дома);\nШирокая (все дома);\nЭнергетиков (все дома);\nМТФ № 2,3 ЗАО «Колос»;\nКонтрольно-селекционный двор;\nразъезд 1482 км;\nразъезд Очеретоватый;\nМагистральная (нечетная);\nЖелезнодорожная будка.\nПереулки:\nСтроителей (все дома);\nЗеленый (все дома);\nЦветочный (все дома);\nВокзальный (все дома).\n";
                    break;
                case 31:
                    title.Text = "Госян Анаит Руслановна";
                    image.Source = ImageSource.FromResource("Ksenya.GosyanAnait.jpg");
                    text.Text = $"Территориальная группа № 19\nБеспартийная\nДата и место рождения: 04.01.1986 в с. Карачинар Шаумяновского р-на Азербайджанской ССР.\nСфера деятельности: Культура и искусство.\nМесто работы: МКУ «Ильинский СДК».\nДолжность: Директор.\nОбразование: Среднее профессиональное образование.\nУчебные заведения: ГБПОУ Краснодарского края «Новопокровский многоотраслевой техникум», Пекарь.\nДепутатство: Депутат городского поселения, сельского поселения.";
                    break;
                case 32:
                    title.Text = "Борохов Александр Геннадьевич";
                    image.Source = ImageSource.FromResource("Ksenya.BorohovAlex.jpg");
                    text.Text = $"Территориальная группа № 19 \nЧлен партии «ЕДИНАЯ РОССИЯ»\nДата и место рождения: 22.06.1986 в с. Белая Глина, Белоглинского района, Краснодарского края.\nСфера деятельности: Прочие\nМесто работы: ООО «Росгосстрах-Юг», менеджер офисных продаж страхового отдела в с. Белая Глина.\nДолжность: менеджер.\nОбразование: Высшее образование — специалитет, магистратура.\nУчебные заведения:\n2003 г. — 2008 г. Государственное образовательное учреждение высшего профессионального образования «Майкопский государственный технологический университет» , Экономист-менеджер.\nДепутатство: Депутат городского округа, муниципального района.";
                    break;
                case 33:
                    title.Text = "Толстопятов Антон Васильевич";
                    image.Source = ImageSource.FromResource("Ksenya.Tolstopyatov.jpg");
                    text.Text = $"Территориальная группа № 19\nБеспартийный\nДата и место рождения: 07.05.1992 в станица Павловская Павловского района Краснодарского края.\nМесто работы: Индивидуальный предприниматель.\nДолжность:\nОбразование: Высшее образование — бакалавриат.\nУчебные заведения:\n2015 г. МГУ имени Ломоносова, Юриспруденция.\nДепутатство: Депутат городского округа, муниципального района.";
                    break;

            }

            StackLayout stack = new StackLayout();
            stack.Children.Add(image);
            stack.Children.Add(title);
            ScrollView scroll = new ScrollView();
            scroll.Content = text;
            stack.Children.Add(scroll);

            Content = stack;

            InitializeComponent();
        }
    }
}