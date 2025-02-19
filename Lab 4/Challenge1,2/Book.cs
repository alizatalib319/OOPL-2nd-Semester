using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_CHALLENGE_1
{
    public class Book
    {
        public string title;
        public string author;
        public string publisher;
        public string ISBN;
        public int copies;
        public int price;
        public string year;
        public Book(string title, string author, string publisher, string ISBN, int copies, int price,string year)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.ISBN = ISBN;
            this.copies = copies;
            this.price = price;
            this.year = year;
        }
        
        public void ShowBookDetails()
        {
            Console.WriteLine($"Book Title : {title}");
            Console.WriteLine($"Book Author: {author}");
            Console.WriteLine($"Publisher: {publisher}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Copies in stock:{copies}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Year: {year}");
        }
        
    }
    
}
