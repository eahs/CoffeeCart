using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CoffeeCart.Views
{
    public partial class EndPage : ContentPage
    {
        public EndPage()
        {
            InitializeComponent();
            this.Title = "Back";
        }

        private async void _buttonClick(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
            await Navigation.PushAsync(new LoginPage());
        }

    }
}
