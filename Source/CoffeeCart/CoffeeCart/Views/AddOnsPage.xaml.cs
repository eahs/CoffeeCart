using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CoffeeCart.Views
{
    public partial class AddOnsPage : ContentPage
    {
        public AddOnsPage()
        {
            InitializeComponent();
            this.Title = "Add Ons";
        }
        private async void NextButtonToQuan(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuantityPage());
        }
    }
}
