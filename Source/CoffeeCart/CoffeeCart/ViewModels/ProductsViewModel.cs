using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CoffeeCart.Models;
using Newtonsoft.Json;
using System.Linq;
using RestSharp;

namespace CoffeeCart.ViewModels
{
    public class ProductsViewModel : BaseViewModel
    {
        public List<Product> Products { get; set; }
        public ObservableCollection<Product> BeverageProducts { get; set; }

        public ProductsViewModel()
        {
            Products = new List<Product>();
            BeverageProducts = new ObservableCollection<Product>();

            LoadItemsCommand.Execute(null);
        }

        protected override async Task LoadItemsAsync()
        {
            await Task.Delay(1);

            // Basic pattern

            try
            {
                bool success = false;
                var client = new RestClient(GlobalConstants.EndPointURL);
                var request = new RestRequest
                {
                    Timeout = GlobalConstants.RequestTimeout
                };
                request.Resource = GlobalConstants.ProductsEndPointRequestURL;

                // Make async request to obtain data
                var response = await client.ExecuteAsync(request);


                if (response.IsSuccessful)
                {
                    var items = JsonConvert.DeserializeObject<List<Product>>(response.Content) ?? new List<Product>();

                    foreach (var product in items)
                    {
                        Products.Add(product);
                    }

                    var bev = Products.Where(x => x.Type == ProductType.Beverage).ToList();
                    foreach (var beverage in bev)
                    {
                        BeverageProducts.Add(beverage);
                    }

                    OnPropertyChanged("BreakfastProducts");

                    IsError = false;
                    DataAvailable = true;

                }
                else
                {
                    // An error occurred that is stored
                    ErrorMessage = "An error occurred";
                    DataAvailable = false;
                    IsError = true;
                }
            }
            catch (Exception e)
            {
                // An exception occurred
                DataAvailable = false;
            }
           
        }
    }
}
