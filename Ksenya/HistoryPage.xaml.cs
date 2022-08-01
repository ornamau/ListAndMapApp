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
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage()
        {
            ScrollView scroll = new ScrollView();
            StackLayout stack = new StackLayout
            {
                Spacing = 2
            };

            Button soziv1 = new Button
            {
                Text = $"1 созыв"
            };
            stack.Children.Add(soziv1);
            soziv1.Clicked += soziv_ClickedAsync;

            Button soziv2 = new Button
            {
                Text = $"2 созыв"
            };
            stack.Children.Add(soziv2);
            soziv2.Clicked += soziv_ClickedAsync;

            Button soziv3 = new Button
            {
                Text = $"3 созыв"
            };
            stack.Children.Add(soziv3);
            soziv3.Clicked += soziv_ClickedAsync;

            Button soziv4 = new Button
            {
                Text = $"4 созыв"
            };
            stack.Children.Add(soziv4);
            soziv4.Clicked += soziv_ClickedAsync;

            Button soziv5 = new Button
            {
                Text = $"5 созыв"
            };
            stack.Children.Add(soziv5);
            soziv5.Clicked += soziv_ClickedAsync;

            Button soziv6 = new Button
            {
                Text = $"6 созыв"
            };
            stack.Children.Add(soziv6);
            soziv6.Clicked += soziv_ClickedAsync;


            scroll.Content = stack;
            Content = scroll;

            InitializeComponent();
        }

        private async void soziv_ClickedAsync(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            string id = button.Text;

            switch (id)
            {
                case "1 созыв":
                    await Navigation.PushAsync(new UchastokTemplate(34));
                    break;
                case "2 созыв":
                    await Navigation.PushAsync(new UchastokTemplate(35));
                    break;
                case "3 созыв":
                    await Navigation.PushAsync(new UchastokTemplate(36));
                    break;
                case "4 созыв":
                    await Navigation.PushAsync(new UchastokTemplate(37));
                    break;
                case "5 созыв":
                    await Navigation.PushAsync(new UchastokTemplate(38));
                    break;
                case "6 созыв":
                    await Navigation.PushAsync(new UchastokTemplate(39));
                    break;

            }
        }
    }
}