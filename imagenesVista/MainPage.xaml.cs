using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace imagenesVista
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }




        async void OnTapGestureRecognizerTapped(Object sender, EventArgs args)
        {


            {
                var ima = (Image)sender;


                await this.Navigation.PushModalAsync(new Page1(ima));
            }

        }

        async void OnTapGestureRecognizerTapped2(object sender, EventArgs args)
        {
            var imagen = (Image)sender;
            await this.Navigation.PushModalAsync(new Page2(imagen));
        }
    }



}

