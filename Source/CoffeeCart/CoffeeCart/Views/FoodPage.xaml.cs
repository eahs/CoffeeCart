using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CoffeeCart.Views
{
    public partial class FoodPage : ContentPage
    {
        public FoodPage()

        {
            InitializeComponent();
            this.Title = "Food";

        }

        private async void __buttonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EndPage());
        }

    }
}
