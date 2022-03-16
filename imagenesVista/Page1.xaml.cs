using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace imagenesVista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(object sender)
        {
            InitializeComponent();
            var imagen = (Image)sender;
            x1.Source = imagen.Source;
        }



        void Pinch(object sender, PinchGestureUpdatedEventArgs e)
        {
            
            this.Navigation.PopModalAsync();
        }
    }
}