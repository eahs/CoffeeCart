using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CoffeeCart.Views
{
    public partial class PickCreamerPage : ContentPage
    {
        public PickCreamerPage()
        {
            InitializeComponent();
            this.Title = "Creamer Page";

        }

        private async void __button__Clicked(object sender, EventArgs e)
        { 
            await Navigation.PushAsync(new SugarPage());
        }

    }
}