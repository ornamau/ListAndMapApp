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
                    await Navigation.PushAsync(new Page2());
                    break;
            }

            
        }
    }
}