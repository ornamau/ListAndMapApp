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
    public partial class Deputats : ContentPage
    {
        public Deputats()
        {
            StackLayout stack = new StackLayout();

            Button gosyan = new Button
            {
                Text = "Госян Анаит Руслановна"
            };
            stack.Children.Add(gosyan);
            gosyan.Clicked += Deputat_Clicked;

            Button borohov = new Button
            {
                Text = "Борохов Александр Геннадьевич"
            };
            stack.Children.Add(borohov);
            borohov.Clicked += Deputat_Clicked;

            Button tolstopyatov = new Button
            {
                Text = "Толстопятов Антон Васильевич"
            };
            stack.Children.Add(tolstopyatov);
            tolstopyatov.Clicked += Deputat_Clicked;

            Content = stack;
            InitializeComponent();
        }

        private async void Deputat_Clicked(object sender, EventArgs e)
        {
            string name = ((Button)sender).Text;

            switch (name)
            {
                case "Госян Анаит Руслановна":
                    Navigation.PushAsync(new UchastokTemplate(31));
                    break;
                case "Борохов Александр Геннадьевич":
                    Navigation.PushAsync(new UchastokTemplate(32));
                    break;
                case "Толстопятов Антон Васильевич":
                    Navigation.PushAsync(new UchastokTemplate(33));
                    break;
            }
        }
    }
}