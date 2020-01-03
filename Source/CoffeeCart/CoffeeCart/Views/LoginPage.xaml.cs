using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CoffeeCart.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.Title = "Login";

        }

        private async void LoginButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TypeOfCoffeePage());
        }

    }
}
