using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Ksenya
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            Position position = new Position(46.136373701241304 ,39.785511885559416);
            MapSpan mapSpan = new MapSpan(position,0.1,0.1);
            Map map = new Map(mapSpan);

            Pin pin = new Pin
            {
                Label = "16",
                Position = new Position(46.13358436746722, 39.823000767802235)
            };
            Pin pin1 = new Pin
            {
                Label = "17",
                Position = new Position(46.13368760686640, 39.791990252458730)
            };
            Pin pin2 = new Pin
            {
                Label = "18",
                Position = new Position(46.13432541387678, 39.80949606913936)
            };

            pin.Clicked += OpenPage;
            pin1.Clicked += OpenPage;
            pin2.Clicked += OpenPage;

            map.Pins.Add(pin);
            map.Pins.Add(pin1);
            map.Pins.Add(pin2);

            Content = map;

            InitializeComponent();
        }

        private async void OpenPage(object sender, EventArgs e)
        {
            int label = int.Parse(((Pin)sender).Label);

            switch (label)
            {
                case 16:
                    Navigation.PushAsync(new Page2());
                    break;
            }
        }
    }
}