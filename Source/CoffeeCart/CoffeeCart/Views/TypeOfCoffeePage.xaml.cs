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
        private async void _buttonClickedc(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SizePage());
        }
        private async void _buttonClickedb(object sender, EventArgs e)   
        {
            await Navigation.PushAsync(new (EspressoSizePage));
        }
    }
    
    
}
