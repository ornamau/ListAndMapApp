using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ksenya
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegularInfoPage : ContentPage
    {
        public RegularInfoPage()
        {
            Label text = new Label
            {
                Text = $"Законодательное Собрание Краснодарского края - постоянно действующий (представительный) законодательный орган государственной власти края. Законодательное Собрание разрабатывает и принимает законы, создающие основу народовластия, гарантий прав и свобод жителей края.\nДействует на основании Закона Краснодарского края «О Законодательном собрании Краснодарского края».\nЗаконодательное собрание Краснодарского края шестого созыва было избрано 10 сентября 2017 года. Законодательное собрание является однопалатным.\nКто может стать депутатом?\nДепутатом Законодательного собрания края может быть избран гражданин Российской Федерации, достигший 21 года, обладающий избирательным правом в соответствии с федеральными законами и законами края.\nДепутаты Законодательного собрания края обладают неприкосновенностью на территории Краснодарского края, гарантируемой федеральным законом и законом края, в течение всего срока полномочий."
            };
            text.FontSize = 16;
            text.HorizontalTextAlignment = TextAlignment.Center;

            Label title = new Label { Text = "Общая информация" };
            title.FontSize = 20;
            title.FontAttributes = FontAttributes.Bold;
            title.HorizontalTextAlignment = TextAlignment.Center;

            StackLayout stack = new StackLayout();
            ScrollView scroll = new ScrollView();
            scroll.Content = text;
            stack.Children.Add(title);
            stack.Children.Add(scroll);
            Content = stack;
            InitializeComponent();
        }
    }
}