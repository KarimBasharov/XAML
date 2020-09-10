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
    public partial class RGB : ContentPage
    {
        public RGB()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //Editor1.FontSize = Slider1.Value;
        }
        private void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {

            if (e.NewValue > 0)
            {
                frame1.BackgroundColor = Color.FromRgb(255, 0, 0);
                Slider1.Value = e.NewValue;
            }
        }
        private void Slider2_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue > 0)
            {
                frame1.BackgroundColor = Color.FromRgb(0, 255, 0);
                Slider2.Value = e.NewValue;
            }
        }

        private void Slider3_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue > 0)
            {
                frame1.BackgroundColor = Color.FromRgb(0, 0, 255);
                Slider3.Value = e.NewValue;
            }
        }

    }
}