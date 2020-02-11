using System;
namespace CoffeeCart.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ProductType Type { get; set; }

        public string Price { get; set; }
    }

    public enum ProductType
    {
        Beverage,
        Pastry
    }
}
