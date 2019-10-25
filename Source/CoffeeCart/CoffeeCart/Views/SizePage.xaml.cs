using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CoffeeCart.Views
{
    public partial class SizePage : ContentPage
    {
        public SizePage()
        {
            InitializeComponent();
            this.Title = "Size";
        }

        private async void _button__Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PickCreamerPage());
        }
    }
}
