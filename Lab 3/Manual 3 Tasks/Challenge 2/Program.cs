using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            while (true)
            {
                char option;
                string productname, category;
                float price;
                int quantity,minimumquantity;
                option = menu();
                if (option == '1')
                {
                    Console.WriteLine("Enter Product Name: ");
                    productname=Console.ReadLine();
                    Console.WriteLine("Enter category name: ");
                    category = Console.ReadLine();
                    Console.WriteLine("Enter price of product: ");
                    price=float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter stock quantity: ");
                    quantity=int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter minimum stock quantity: ");
                    minimumquantity=int.Parse(Console.ReadLine());
                    Product product = new Product(productname,category,price,quantity,minimumquantity);
                    products.Add(product);
                    Console.WriteLine("The product has been added successfully");
                }
                if (option == '2')
                {
                    foreach(Product product in products)
                    {
                        product.printProducts();
                    }
                }
                if(option=='3')
                {
                    float maxunitprice=0;
                    foreach(Product product in products)
                    {
                        product.maxPrice(maxunitprice);
                    }
                    Console.WriteLine("Highest unit price of product: "+maxunitprice);
                }
                if(option=='4')
                {
                    
                    foreach (Product product in products)
                    {
                        float salesprice;
                        if(product.Category=="Groceries"|| product.Category=="groceries")
                        {
                            salesprice =product.Price * 0.1f;
                            Console.WriteLine($"{product.Name} {salesprice}" );
                        }
                        if (product.Category == "Fruits" || product.Category == "fruits")
                        {
                            salesprice = product.Price * 0.05f;
                            Console.WriteLine($"{product.Name} {salesprice}");
                        }
                        else
                        {
                            salesprice = product.Price * 0.15f;
                            Console.WriteLine($"{product.Name} {salesprice}");
                        }

                    }
                    
                }
                if (option == '5')
                {
                    foreach (Product product in products)
                    {
                        if (product.StockQuantity<product.MinimumStockQuantity)
                        {
                            Console.WriteLine($"Product Name: {product.Name} Stock Quantity: {product.StockQuantity} Minimum Stock Quantity: {product.MinimumStockQuantity}");
                        }
                    }   
                }
                if( option =='6')
                {
                    return ;
                }

            }
        }
        static char menu()
        {
            char option;
            Console.WriteLine("[1]==>Add Product");
            Console.WriteLine("[2]==>View All Products");
            Console.WriteLine("[3]==>Find Product with highest unit price");
            Console.WriteLine("[4]==>View sales tax of All Products");
            Console.WriteLine("[5]==>Products to be Ordered");
            Console.WriteLine("[6]==>Exit");
            option=char.Parse(Console.ReadLine());
            return option;
        }
    }
}
