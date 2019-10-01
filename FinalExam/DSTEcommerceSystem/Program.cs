using System;
using System.Collections.Generic;

namespace DSTEcommerceSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ABC E-Commerce System");
            var productList = new List<Product>();
            var boughtProductList = new List<Product>();
            IEcommerceModel ecommerceModel = new EcommerceModel(productList);

            while(true)
            {
                OptionMessage();
                Console.WriteLine("Please Select an Option :");

                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    ecommerceModel.AddProduct();
                }
                else if (option == 2)
                {
                    ecommerceModel.DisplayProduct();
                }
                else if (option == 3)
                {
                    ecommerceModel.BuyProduct();
                }
                else if (option == 4)
                {
                    ecommerceModel.DisplayBoughtProduct();
                }
                else if (option == 5)
                {
                    ecommerceModel.TotalPriceOfBoughtProduct();
                }
                else
                {
                    break;
                }
                Console.WriteLine("<======================================>");

            }
            Console.WriteLine("Thank You for using ABC E-Commerce System");
        }
        public static void OptionMessage()
        {
            Console.WriteLine("1: ADD PRODUCT TO STORE");
            Console.WriteLine("2: SHOW PRODUCT LIST OF STORE");
            Console.WriteLine("3: BUY PRODUCT");
            Console.WriteLine("4: SHOW ALL BOUGHT PRODUCT LIST");
            Console.WriteLine("5: SHOW TOTAL PRICE OF ALL BOUGHT PRODUCT");
            Console.WriteLine("6: EXIT");
        }
    }
}
