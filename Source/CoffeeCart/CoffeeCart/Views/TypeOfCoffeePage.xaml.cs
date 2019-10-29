using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CoffeeCart.Views
{
    public partial class TypeOfCoffeePage : ContentPage
    {
        public TypeOfCoffeePage()
        {
            InitializeComponent();
            this.Title = "Type Of Coffee";
        }
        private async void _buttonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SizePage());
        }
    }
    
    
}
