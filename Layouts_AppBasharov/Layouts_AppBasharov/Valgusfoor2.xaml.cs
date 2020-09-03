using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layouts_AppBasharov
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor2 : ContentPage
    {
        public Valgusfoor2()
        {
            //InitializeComponent();
            Label punane = new Label()
            {
                Text = "Punane",
                TextColor = Color.Red,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            Frame pun = new Frame()
            {
                BackgroundColor = Color.Red,
                Content = punane,
                CornerRadius = 80,
                Margin = new Thickness(40, 115, 40, 115)
            };
            Label kollane = new Label()
            {
                Text = "Kollane",
                TextColor = Color.Yellow,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            Frame kol = new Frame()
            {
                BackgroundColor = Color.Yellow,
                Content = kollane,
                CornerRadius = 80,
                Margin = new Thickness(40, 115, 40, 115)
            };
            Label roheline = new Label()
            {
                Text = "Roheline",
                TextColor = Color.Green,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            Frame roh = new Frame()
            {
                BackgroundColor = Color.Green,
                Content = roheline,
                CornerRadius = 80,
                Margin = new Thickness(80, 0, 80, 0),
                VerticalOptions = 
            };
            Button but = new Button()
            {
                Text = "Välja",
                BackgroundColor = Color.Gray,

            };
            Button but2 = new Button()
            {
                Text = "Sisse",
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { pun, kol, roh, but, but2 }
            };
            stackLayout.Orientation = StackOrientation.Horizontal;
            Content = stackLayout;
        }
    }
}