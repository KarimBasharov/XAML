using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layouts_AppBasharov
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor2 : ContentPage
    {
        Label punane, kollane, roheline;
        Frame pun, kol, roh;
        Button sisse, valja;
        public Valgusfoor2()
        {
            //InitializeComponent();
            punane = new Label()
            {
                Text = "Punane",
                TextColor = Color.Black,
                FontSize = 15,
                FontAttributes = FontAttributes.Bold
            };
            pun = new Frame()
            {
                BackgroundColor = Color.Red,
                Content = punane,
                CornerRadius = 80,
                Padding = 50,
                HorizontalOptions=LayoutOptions.Center
            };
            kollane = new Label()
            {
                Text = "Kollane",
                TextColor = Color.Black,
                FontSize = 15,
                FontAttributes = FontAttributes.Bold
            };
            kol = new Frame()
            {
                BackgroundColor = Color.Yellow,
                Content = kollane,
                CornerRadius = 80,
                Padding = 50,
                HorizontalOptions = LayoutOptions.Center
            };
            roheline = new Label()
            {
                Text = "Roheline",
                TextColor = Color.Black,
                FontSize = 15,
                FontAttributes = FontAttributes.Bold
            };
            roh = new Frame()
            {
                BackgroundColor = Color.Green,
                Content = roheline,
                CornerRadius = 80,
                Padding = 50,
                HorizontalOptions = LayoutOptions.Center

            };
            valja = new Button()
            {
                Text = "Välja",
                BackgroundColor = Color.Gray,
                HorizontalOptions = LayoutOptions.End

            };
            sisse = new Button()
            {
                Text = "Sisse",
                BackgroundColor = Color.Gray,
                HorizontalOptions = LayoutOptions.Start
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { pun, kol, roh, sisse, valja }
            };
            sisse.Clicked += Sisse_Clicked;
            valja.Clicked += Valja_Clicked;
            Content = stackLayout;

            var tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            pun.GestureRecognizers.Add(tap);
            kol.GestureRecognizers.Add(tap);
            roh.GestureRecognizers.Add(tap);
        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            Frame fr = sender as Frame;
            if (fr == pun)
            {
                punane.Text = "Стоп!!!";
            }
            if (fr == kol)
            {
                kollane.Text = "Внимание!!!";
            }
            if (fr == roh)
            {
                roheline.Text = "Вперед!!!";
            }
        }

        private async void Valja_Clicked(object sender, EventArgs e)
        {

            punane.Text = "!Светофор не работает!";
            kollane.Text = "!Светофор не работает!";
            roheline.Text = "!Светофор не работает!";
            kol.BorderColor = Color.WhiteSmoke;
            for (int i = 0; i < 100; i++)
            {

                pun.BackgroundColor = Color.Gray;
                kol.BackgroundColor = Color.Yellow;
                roh.BackgroundColor = Color.Gray;


                await Task.Run(() => Thread.Sleep(3000));

            }
        }
        Random rnd = new Random();
        private async void Sisse_Clicked(object sender, EventArgs e)
        {
            punane.Text = " Стоп!!!";
            kollane.Text = "Внимание!!!";
            roheline.Text = "Вперед!!!";
            pun.BorderColor = Color.WhiteSmoke;
            for (int i=0; i< 100; i++)
            {
                
                pun.BackgroundColor = Color.Red;
                kol.BackgroundColor = Color.Yellow;
                roh.BackgroundColor = Color.Green;
                

                await Task.Run(() => Thread.Sleep(3000));
            }
        }
    }
}