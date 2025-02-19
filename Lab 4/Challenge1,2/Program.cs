using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_CHALLENGE_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            choice = menu();
            Book[] books = new Book[100];
            List<Member> members = new List<Member>(); 
            int bookCount = 0;
            while (true)
            {
                if (choice == "1")
                {
                    
                    string title, author, publisher, ISBN,year;
                    int copies, price;
                    Console.Write("Enter book title: ");
                    title = Console.ReadLine();
                    Console.Write("Enter book author: ");
                    author = Console.ReadLine();
                    Console.Write("Enter book publisher: ");
                    publisher = Console.ReadLine();
                    Console.Write("Enter book isbn: ");
                    ISBN = Console.ReadLine();
                    Console.Write("Enter book Copies: ");
                    copies = int.Parse(Console.ReadLine());
                    Console.Write("Enter book price: ");
                    price = int.Parse(Console.ReadLine());
                    Console.Write("Enter year of Publication: ");
                    year= Console.ReadLine();   
                    Book book = new Book(title,author,publisher,ISBN,copies,price,year);
                    books[bookCount] = book;
                    bookCount++;
                    Console.WriteLine("Book is added successfully");
                }
                if (choice == "2")
                {
                    string title;
                    Console.Write("Enter book title: ");
                    title = Console.ReadLine();
                    foreach(Book book in books)
                    {
                        if (title == book.title)
                        {
                            book.ShowBookDetails();
                            break;
                        }
                    }
                }
                if (choice == "3")
                {
                    string isbn;
                    Console.Write("Enter book isbn: ");
                    isbn = Console.ReadLine();
                    foreach (Book book in books)
                    {
                        if (isbn == book.ISBN)
                        {
                            book.ShowBookDetails();
                            break;
                        }
                    }
                }
                if(choice=="4")
                {
                    string title;
                    Console.Write("Enter book title: ");
                    title = Console.ReadLine();
                    foreach(Book book in books)
                    {
                        if(title == book.title)
                        {
                            char subopt;
                            Console.Write("Enter 1 to increase the stock and 2 to decrease the stock: ");
                            subopt=char.Parse(Console.ReadLine());
                            if (subopt=='1')
                            {
                                book.copies=book.copies+1;
                            }
                            if(subopt==2)
                            {
                                book.copies=book.copies-1;
                            }
                            break;
                        }
                    }
                }
                if(choice=="5")
                {
                    char subOpt;
                    Console.Write("Enter 1 for Member with id or 2 for member with non-id: ");
                    subOpt = char.Parse(Console.ReadLine());
                    if(subOpt=='1')
                    {
                        string name;
                        int id;
                        Console.Write("Enter member name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter member id: ");
                        id = int.Parse(Console.ReadLine());
                        Member member = new Member(name, id);
                        members.Add(member);
                        Console.WriteLine("Member is successfully added");
                    }
                    if (subOpt == '2')
                    {
                        string name;
                        Console.Write("Enter member name: ");
                        name = Console.ReadLine();
                        Member member = new Member(name);
                        members.Add(member);
                        Console.WriteLine("Member is successfully added");
                    }
                    
                }
                if(choice=="6")
                {
                    
                    string name;
                    Console.WriteLine("Enter member name: ");
                    name = Console.ReadLine();
                    foreach (Member member in members)
                    {
                        if (name == member.name)
                        {
                            member.showData();
                        }
                    }
                }
                if(choice=="7")
                {
                    char subOpt;
                    Console.Write("Enter 1 for Member with id or 2 for member with non-id: ");
                    subOpt = char.Parse(Console.ReadLine());
                    if (subOpt == '1')
                    {
                        string oldname;
                        Console.Write("Enter old name: ");
                        oldname = Console.ReadLine();
                        string name;
                        int id;
                        char subOption;
                        subOption = nameidChangeMenu();
                        foreach (Member member in members)
                        {
                            if (oldname == member.name)
                            {
                                if (subOption == '1')
                                {
                                    Console.Write("Enter name: ");
                                    member.name = Console.ReadLine();
                                }
                                if (subOption == '2')
                                {
                                    Console.Write("Enter id: ");
                                    member.id = int.Parse(Console.ReadLine());
                                }
                                if (subOpt == '3')
                                {
                                    Console.Write("Enter name: ");
                                    member.name = Console.ReadLine();
                                    Console.Write("Enter id: ");
                                    member.id = int.Parse(Console.ReadLine());
                                }
                            }
                        }
                    }
                    if(subOpt=='2')
                    {
                        string oldname;
                        Console.Write("Enter old name: ");
                        oldname = Console.ReadLine();
                        foreach (Member member in members)
                        {
                            if (oldname == member.name)
                            {
                                Console.Write("Enter name: ");
                                member.name = Console.ReadLine();
                            }
                        }
                    }
                }
                if(choice=="8")
                {

                }
                choice =menu();
            }
           
        }
        static string menu()
        {
            string option;
            Console.WriteLine("1.Add a Book");
            Console.WriteLine("2.Search for a Book by Title");
            Console.WriteLine("3.Search for a Book by ISBN");
            Console.WriteLine("4.Update Stock of a Book");
            Console.WriteLine("5.Add a Member");
            Console.WriteLine("6.Search for a Member by Name or ID");
            Console.WriteLine("7.Update Member Information");
            Console.WriteLine("8.Purchase a Book");
            Console.WriteLine("9.Display Total Sales and Membership Stats");
            Console.WriteLine("10.Exit");
            Console.WriteLine("Enter your Option:");

            option = Console.ReadLine();
            return option;
        }
        static char nameidChangeMenu()
        {
            char Option;
            Console.WriteLine("Press 1 if to want to modify only name ");
            Console.WriteLine("Press 2 if to want to modify only id ");
            Console.WriteLine("Press 3 if to want to modify name and id both ");
            Option = char.Parse(Console.ReadLine());
            return Option;
        }
    }
}
