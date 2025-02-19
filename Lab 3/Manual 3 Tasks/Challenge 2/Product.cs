using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class Product
    {
        public string Name;
        public string Category;
        public float Price;
        public int StockQuantity;
        public int MinimumStockQuantity;
        public Product(string productname,string category,float price,int quantity,int minimumquantity)
        {
            Name=productname;
            Category=category;
            Price=price;
            StockQuantity=quantity;
            MinimumStockQuantity=minimumquantity;
        }
        public void printProducts()
        {
            Console.WriteLine("Product Name: " + Name);
            Console.WriteLine("Product Category: " + Category);
            Console.WriteLine("Product Price: " + Price);
            Console.WriteLine("Product Stock Quantity" + StockQuantity);
            Console.WriteLine("Product Minimum Stock Quantity: " + MinimumStockQuantity);
        }
        public float maxPrice(float maxunitprice)
        {
            if (Price > maxunitprice)
            {
                return Price;
            }
            else
            {
                return maxunitprice;
            }
        }

    }
}
