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
            Pin pin3 = new Pin
            {
                Label = "19",
                Position = new Position(46.14013240163926, 39.78644535363851)
            };
            Pin pin4 = new Pin
            {
                Label = "20",
                Position = new Position(46.134510400278074, 39.784680813162524)
            };
            Pin pin5 = new Pin
            {
                Label = "21",
                Position = new Position(46.13587354701607, 39.7830945898305)
            };
            Pin pin6 = new Pin
            {
                Label = "22",
                Position = new Position(46.1315308092053, 39.77069834694149)
            };
            Pin pin7 = new Pin
            {
                Label = "23",
                Position = new Position(46.13952354060908, 39.76769105857802)
            };
            Pin pin8 = new Pin
            {
                Label = "24",
                Position = new Position(46.139843924371675, 39.76647127260424)
            };
            Pin pin9 = new Pin
            {
                Label = "25",
                Position = new Position(46.14924577071147, 39.7872523071395)
            };
            Pin pin10 = new Pin
            {
                Label = "26",
                Position = new Position(46.150477744278604, 39.788525355491096)
            };
            Pin pin11 = new Pin
            {
                Label = "27",
                Position = new Position(46.127997943499025, 39.77186579781819)
            };
            Pin pin12 = new Pin
            {
                Label = "28",
                Position = new Position(46.12265210644139, 39.77301482665407)
            };
            Pin pin13 = new Pin
            {
                Label = "29",
                Position = new Position(46.12228844272817, 39.79886219781804)
            };
            Pin pin14 = new Pin
            {
                Label = "30",
                Position = new Position(46.12492923062684, 39.83610452041962)
            };



            pin.Clicked += OpenPage;
            pin1.Clicked += OpenPage;
            pin2.Clicked += OpenPage;
            pin3.Clicked += OpenPage;
            pin4.Clicked += OpenPage;
            pin5.Clicked += OpenPage;
            pin6.Clicked += OpenPage;
            pin7.Clicked += OpenPage;
            pin8.Clicked += OpenPage;
            pin9.Clicked += OpenPage;
            pin10.Clicked += OpenPage;
            pin11.Clicked += OpenPage;
            pin12.Clicked += OpenPage;
            pin13.Clicked += OpenPage;
            pin14.Clicked += OpenPage;

            map.Pins.Add(pin);
            map.Pins.Add(pin1);
            map.Pins.Add(pin2);
            map.Pins.Add(pin3);
            map.Pins.Add(pin4);
            map.Pins.Add(pin5);
            map.Pins.Add(pin6);
            map.Pins.Add(pin7);
            map.Pins.Add(pin8);
            map.Pins.Add(pin9);
            map.Pins.Add(pin10);
            map.Pins.Add(pin11);
            map.Pins.Add(pin12);
            map.Pins.Add(pin13);
            map.Pins.Add(pin14);

            Content = map;

            InitializeComponent();
        }

        private async void OpenPage(object sender, EventArgs e)
        {
            int label = int.Parse(((Pin)sender).Label);

            Navigation.PushAsync(new UchastokTemplate(label));
        }
    }
}