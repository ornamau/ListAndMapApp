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
    public partial class PredsedPage : ContentPage
    {
        public PredsedPage()
        {
            Label text = new Label
            {
                Text = $"Алексей Багмут\nПолномочия: с 14 декабря 1995	по декабрь 1995.\nПартия:	независимый.\nСозыв: I (1994).\nВладимир Бекетов\nПолномочия: с декабря 1995	по 10 сентября 2017.\nПартия: Единая Россия.\nСозывы: II (1998), III (2002), IV (2007), V (2012).\nЮрий Бурлачко\nПолномочия: с 28 сентября 2017 по нынешнее время (действующий).\nПартия: Единая Россия.\nСозыв: VI (2017)."
            };
            text.FontSize = 16;
            text.HorizontalTextAlignment = TextAlignment.Center;

            Label title = new Label { Text = "Председатели ЗСК Краснодарского Края" };
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