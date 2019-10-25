using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CoffeeCart.Views
{
  
    public partial class HomePage : ContentPage
    { 
        public HomePage()
        {
            InitializeComponent();
            this.Title = "Home";
        }

        private async void _button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TypeOfCoffeePage());
        }
    }


}
