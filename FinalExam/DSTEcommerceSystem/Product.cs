using System;
using System.Collections.Generic;
using System.Text;

namespace DSTEcommerceSystem
{
    public class Product
    {
        public Product(string code, string name, double price, int stock)
        {
            Code = code;
            Name = name;
            Price = price;
            Stock = stock;
        }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public int UpdateStock { get; set; }

        public void AddProduct(int quantity)
        {
            Stock += quantity;
        }

        public void BuyProduct(int quantity)
        {
            Stock -= quantity;
        }
        public void Update(int quantity)
        {
            Stock = quantity;
        }
    }
}
