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
    public partial class NewPage : ContentPage
    {
        public NewPage()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void on_Clicked(object sender, EventArgs e)
        {
            int c=rnd.Next(1, 4);
            if (c==1)
            {
                pun.BackgroundColor = Color.Red;
                kol.BackgroundColor = Color.Gray;
                roh.BackgroundColor = Color.Gray;
            }
            else if (c==2)
            {
                pun.BackgroundColor = Color.Gray;
                kol.BackgroundColor = Color.Yellow;
                roh.BackgroundColor = Color.Gray;
            }

            else
            {
                pun.BackgroundColor = Color.Gray;
                kol.BackgroundColor = Color.Gray;
                roh.BackgroundColor = Color.Green;
            }
        }

        private void off_Clicked(object sender, EventArgs e)
        {
            pun.BackgroundColor = Color.Gray;
            kol.BackgroundColor = Color.Gray;
            roh.BackgroundColor = Color.Gray;
        }
    }
}