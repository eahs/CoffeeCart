using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CoffeeCart.Views
{
    public partial class SugarPage : ContentPage
    {
        public SugarPage()
        {
            InitializeComponent();
            this.Title = "Sugar";

        }

        private async void __buttonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EndPage());
        }

    }
}
