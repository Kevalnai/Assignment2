using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Product
    {
        public int ProdID { get; set; }
        public string ProdName { get; set; }
        public double ItemPrice { get; set; }
        public int StockAmount { get; set; }

        // Constructor
        public Product(int prodID, string prodName, double itemPrice, int stockAmount)
        {
            ProdID = prodID;
            ProdName = prodName;
            ItemPrice = itemPrice;
            StockAmount = stockAmount;
        }

        // Method to increase stock
        public void IncreaseStock(int quantity)
        {
            if (quantity > 0)
                StockAmount += quantity;
        }

        // Method to decrease stock
        public void DecreaseStock(int quantity)
        {
            if (quantity > 0 && StockAmount - quantity >= 0)
                StockAmount -= quantity;
        }
    }
}
