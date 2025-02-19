using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab4
{
    internal class book
    {
        public string title;
        public string[] author=new string[4];
        public string publisher;
        public   string ISBN;
        public  float price;
        public int stock;
        public int year;
        public  string tax;
        public book(string title, string[] author, string publisher,  string iSBN,  float price, int stock, int year)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            ISBN = iSBN;
            this.price = price;
            this.stock = stock;
            this.year = year;
            this.tax = "5%";
        }
        public book(book book)
        {
            this.title = book.title;
            this.author = book.author;
            this.publisher = book.publisher;
            this.stock = book.stock;
            this.year = book.year;
            this.ISBN = book.ISBN;
        }
        public void salebook()
        {
            
            Console.Write(title);
            Console.Write(price.ToString());
            Console.Write("0%".ToString());
            Console.Write("5%".ToString());
            price = ((price) * 1.05F);
            Console.Write(price.ToString());
        }
        public void salebook1()
        {
           
            Console.Write(title);
            Console.Write(price.ToString());
            Console.Write("10%");
            Console.Write("5%".ToString());
            price = ((price) * 9.5F);
            Console.Write((price).ToString());
        }

        public void display(int x,int y)
        {
           
            Console.WriteLine( title);
            Console.WriteLine((author[2]));
            Console.WriteLine((author[3]));
            Console.WriteLine( price.ToString());
            Console.WriteLine( stock.ToString());
            Console.WriteLine( year.ToString());
            Console.WriteLine( ISBN);
            Console.WriteLine( publisher);
            
        }
        public void output(int x,int y)
        {
          
           
            Console.WriteLine("Title" + title);
          
            Console.WriteLine(("Author1" + author[0]));
         
            Console.WriteLine(("Author2" + author[1]));
         
            Console.WriteLine("Author3"+ (author[2]));
         
            Console.WriteLine(("Author4" + (author[3])));
          
            Console.WriteLine("Price " + price.ToString());
         
            Console.WriteLine("Stock " + stock.ToString());
        
            Console.WriteLine("Year" + year.ToString());
         
            Console.WriteLine("ISBN" + ISBN);
           
          
            Console.WriteLine("Publisher" + publisher);
            
            Console.WriteLine("Press any Key for Going back");
            Console.ReadKey();
        }
      
    }
}
