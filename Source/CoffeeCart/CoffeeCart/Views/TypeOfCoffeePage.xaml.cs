using System;
using System.Collections.Generic;
using CoffeeCart.ViewModels;
using Xamarin.Forms;

namespace CoffeeCart.Views
{
    public partial class TypeOfCoffeePage : ContentPage
    {
        public TypeOfCoffeePage()
        {
            InitializeComponent();
            this.Title = "Type Of Coffee";
            this.BindingContext = new ProductsViewModel();
        }
        private async void _buttonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SizePage());
            string s = (sender as Button).ContentLayout.ToString();

        }

        public void ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // ProductsListView.SelectedItem
        }
    }
    
    
}
