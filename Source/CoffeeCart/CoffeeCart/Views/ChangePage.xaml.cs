using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CoffeeCart.Views
{
    public partial class ChangePage : ContentPage
    {
        public ChangePage()
        {
            InitializeComponent();
            this.Title = "Change";

        }

        private async void _buttonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EndPage());

        }
    }
}
