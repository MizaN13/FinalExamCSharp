using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSTEcommerceSystem
{
    public class EcommerceModel : IEcommerceModel
    {
        private List<Product> productList;
        private List<Product> boughtProductList = new List<Product>();

        public EcommerceModel(List<Product> productList)
        {
            this.productList = productList;
        }

        public void AddProduct()
        {
            Console.WriteLine("Product Code: ");
            string code = Console.ReadLine();
            Console.WriteLine("Product Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Product Price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Product Stock: ");
            int stock = Convert.ToInt32(Console.ReadLine());
            int updateStock = stock;

            Product p = new Product(code, name, price, stock);
            productList.Add(p);
            Console.WriteLine("Successfully Product Added");

        }

        public void BuyProduct()
        {
            Console.WriteLine("Product Code: ");
            string buyCode = Console.ReadLine();

            Product searchProduct = productList
                .Where(p => p.Code == buyCode)
                .FirstOrDefault();
            Product updateStock = productList
                .Where(p => p.Code == buyCode)
                .FirstOrDefault();
            //bool flag = false;
            //int buyStock = 0;
            if (searchProduct != null)
            {
                Console.WriteLine("Product quantity: ");
                int buyStock = Convert.ToInt32(Console.ReadLine());
                


                if (searchProduct.Stock >= buyStock)
                {
                    //searchProduct.Update(buyStock);

                    searchProduct.BuyProduct(buyStock);
                    boughtProductList.Add(searchProduct);
                    //foreach(var item in boughtProductList)
                    //{
                    //    item.Stock = buyStock;
                    //}

                    //flag = true;
                    Console.WriteLine("Successfully Product Bought");
                }

                else
                {
                    Console.WriteLine("Sorry given quantity is not available on stock");
                }
            }
            //if (flag == true)
            //{
            //    updateStock.Update(buyStock);
            //    boughtProductList.Add(updateStock);
            //}
            else
            {
                Console.WriteLine("Product Not Found");
            }

        }

        public void DisplayProduct()
        {
            var table = new ConsoleTable("Code", "Name", "Price", "Remaining Stock");

            foreach (var item in productList)
            {
                table.AddRow(item.Code, item.Name, item.Price, item.Stock);
            }
            table.Write();
        }

        public void DisplayBoughtProduct()
        {
            var table = new ConsoleTable("Code", "Name", "Price", "Stock");

            foreach (var item in boughtProductList)
            {
                table.AddRow(item.Code, item.Name, item.Price, item.Stock);
            }
            table.Write();
        }

        public void TotalPriceOfBoughtProduct()
        {
            double tp = 0.0;
            foreach (var item in boughtProductList)
            {
                tp += item.Price * item.Stock;
            }
            Console.WriteLine("Total Price: {0}", tp);
        }
    }
}
