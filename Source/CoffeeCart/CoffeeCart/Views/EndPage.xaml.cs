﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CoffeeCart.Views
{
    public partial class EndPage : ContentPage
    {
        public EndPage()
        {
            InitializeComponent();
            this.Title = "Submit";

        }

        private async void _buttonClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }

    }
}
