using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CoffeeCart.Views
{
    public partial class AddPage : ContentPage
    {
        public AddPage()

        {
            InitializeComponent();
            this.Title = "Add";

        }

        private async void _buttonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EndPage());

        }
    }
}
