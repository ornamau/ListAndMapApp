using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ksenya;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ksenya
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            ScrollView scroll = new ScrollView();
            StackLayout stack = new StackLayout {
                Spacing = 2 };

            for (int i = 16; i <= 30; i++)
            {
                Button butt = new Button {
                Text = $"39-{i}"};
                stack.Children.Add(butt);
                butt.Clicked += Butt_ClickedAsync;
            }
            scroll.Content = stack;
            Content = scroll;

            InitializeComponent();
        }

        private async void Butt_ClickedAsync(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            string id = button.Text;

            switch (id)
            {
                case "39-16":
                    await Navigation.PushAsync(new UchastokTemplate(16));
                    break;
                case "39-17":
                    await Navigation.PushAsync(new UchastokTemplate(17));
                    break;
                case "39-18":
                    await Navigation.PushAsync(new UchastokTemplate(18));
                    break;
                case "39-19":
                    await Navigation.PushAsync(new UchastokTemplate(19));
                    break;
                case "39-20":
                    await Navigation.PushAsync(new UchastokTemplate(20));
                    break;
                case "39-21":
                    await Navigation.PushAsync(new UchastokTemplate(21));
                    break;
                case "39-22":
                    await Navigation.PushAsync(new UchastokTemplate(22));
                    break;
                case "39-23":
                    await Navigation.PushAsync(new UchastokTemplate(23));
                    break;
                case "39-24":
                    await Navigation.PushAsync(new UchastokTemplate(24));
                    break;
                case "39-25":
                    await Navigation.PushAsync(new UchastokTemplate(25));
                    break;
                case "39-26":
                    await Navigation.PushAsync(new UchastokTemplate(26));
                    break;
                case "39-27":
                    await Navigation.PushAsync(new UchastokTemplate(27));
                    break;
                case "39-28":
                    await Navigation.PushAsync(new UchastokTemplate(28));
                    break;
                case "39-29":
                    await Navigation.PushAsync(new UchastokTemplate(29));
                    break;
                case "39-30":
                    await Navigation.PushAsync(new UchastokTemplate(30));
                    break;

            }


        }
    }
}