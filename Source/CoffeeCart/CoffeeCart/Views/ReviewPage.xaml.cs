using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CoffeeCart.Views
{
    public partial class ReviewPage: ContentPage
    {
        public ReviewPage()

        {
            InitializeComponent();
            this.Title = "Review";

        }

        private async void __buttonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChangePage());

        }
        private async void _buttonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPage());

        }
        private async void buttonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EndPage());

        }

    }
}
