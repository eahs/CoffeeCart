using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CoffeeCart.Views
{
  
    public partial class HomePage : ContentPage
    {
        private Button _button;
        public HomePage()
        {
            InitializeComponent();
            this.Title = "Home Page";

            /*
            StackLayout stackLayout = new StackLayout();

            _button = new Button();
            _button.Text = "Go to Sugar.";
            _button.FontSize = 25;
            _button.Margin = 50;
           
            _button.Clicked += _button_Clicked;
            stackLayout.Children.Add(_button);

            Content = stackLayout;
            */
        }

        private async void _button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SugarPage());
        }
    }


}
