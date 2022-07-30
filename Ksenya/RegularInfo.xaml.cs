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

            Button history = new Button
            {
            Text = $"История"
            };
            stack.Children.Add(history);

            Button changes = new Button
            {
                Text = $"Изменения"
            };
            stack.Children.Add(changes);

            Button comitet = new Button
            {
                Text = $"Комитеты"
            };
            stack.Children.Add(comitet);

            Button predsed = new Button
            {
                Text = $"Председатели ЗСК"
            };
            stack.Children.Add(predsed);


            scroll.Content = stack;
            Content = scroll;

            InitializeComponent();
        }
    }
}