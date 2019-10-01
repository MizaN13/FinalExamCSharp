using System;
using System.Collections.Generic;
using System.Text;

namespace DSTEcommerceSystem
{
    public interface IEcommerceModel
    {
        void AddProduct();
        void BuyProduct();
        void DisplayProduct();
        void DisplayBoughtProduct();
        void TotalPriceOfBoughtProduct();
    }
}
