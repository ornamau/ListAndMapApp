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
    public partial class RegularInfo : ContentPage
    {
        public RegularInfo()
        {

            ScrollView scroll = new ScrollView();
            StackLayout stack = new StackLayout
            {
                Spacing = 2
            };

            Button regularinfo = new Button
            {
                Text = $"Общая Информация"
            };
            stack.Children.Add(regularinfo);
            regularinfo.Clicked += Regularinfo_Clicked;

            Button history = new Button
            {
            Text = $"История"
            };
            stack.Children.Add(history);
            history.Clicked += History_ClickedAsync;

            Button changes = new Button
            {
                Text = $"Изменения"
            };
            stack.Children.Add(changes);
            changes.Clicked += Changes_Clicked;

            Button comitet = new Button
            {
                Text = $"Комитеты"
            };
            stack.Children.Add(comitet);
            comitet.Clicked += Comitet_Clicked;

            Button predsed = new Button
            {
                Text = $"Председатели ЗСК"
            };
            stack.Children.Add(predsed);
            predsed.Clicked += Predsed_Clicked;

            Button sostavzsk = new Button
            {
                Text = $"Состав ЗСК"
            };
            stack.Children.Add(sostavzsk);
            sostavzsk.Clicked += Sostavzsk_Clicked;


            scroll.Content = stack;
            Content = scroll;

            InitializeComponent();
        }

        private async void Sostavzsk_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SostavPage());
        }

        private async void Predsed_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PredsedPage());
        }

        private async void Comitet_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComitetPage());
        }

        private async void Changes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChangesPage());
        }

        private async void Regularinfo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegularInfoPage());
        }

        private async void History_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoryPage());
        }
    }
}