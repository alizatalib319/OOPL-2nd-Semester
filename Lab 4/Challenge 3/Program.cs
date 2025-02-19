using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace lab4
{
    internal class Program
    {

        static int TotalAmount = 0;

        static void Main(string[] args)
        {
            string[] author = new string[4] { "ww", "ss", "ss", "ww " };
            List<Member> nonmember = new List<Member>();
            List<Member> members = new List<Member>();
            List<book> Books = new List<book>();
            Member m = new Member("aliza", "0", 30);
            Member m1 = new Member("aliza", "1", 30, 1395);
            members.Add(m1);
            nonmember.Add(m);
            book b1 = new book("ss", author, "2", "22", 2222, 222, 33);
            book b2 = new book("s", author, "2", "22", 2222, 222, 33);
            book b3 = new book("sws", author, "2", "22", 22222, 222, 33);
            book b4 = new book("sse", author, "2", "22", 2222, 222, 33);
            Books.Add(b1);
            Books.Add(b2);
            Books.Add(b3);
            Books.Add(b4);
            string LogIn = "";
            while (LogIn != "3")
            {
                LogIn = MainMenu();
                if (LogIn == "1")
                {
                    while (LogIn != "10")
                    {
                        LogIn = Menu();
                        if (LogIn == "1")
                        {
                            Books.Add(BookAdd());
                        }
                        else if (LogIn == "2")
                        {
                            BookSearchbyName(Books);
                        }
                        else if (LogIn == "3")
                        {
                            BookSearchbyISBN(Books);
                        }
                        else if (LogIn == "4")
                        {
                            Update(Books);
                        }
                        else if (LogIn == "5")
                        {

                        }
                        else if (LogIn == "6")
                        {
                            MemberSearchbyName(nonmember);
                        }
                        else if (LogIn == "7")
                        {
                            MemberSearchbyID(members);
                        }
                        else if (LogIn == "8")
                        {
                            DisplayMembers(members, nonmember);
                        }
                        else if (LogIn == "9")
                        {
                            DisplayBook(Books);
                        }

                    }

                }
                else if (LogIn == "2")
                {
                    while (LogIn != "4")
                    {
                        LogIn = CustomerMenu();
                        if (LogIn == "1")
                        {
                            int number = -1;
                            LogIn = login(nonmember, members, ref number);
                            if (LogIn == "0")
                            {
                                NonMemberBuy(Books, nonmember, number);
                            }
                            if (LogIn == "1")
                            {
                                NonMemberBuy(Books, members, number);
                            }
                        }
                        else if (LogIn == "2")
                        {
                            AddMember(members);
                        }
                        else if (LogIn == "3")
                        {
                            ADDnonMemberCustomer(nonmember);
                        }

                    }

                }

            }
        }

        static string MainMenu()
        {


            string option;

            Console.WriteLine("Choose\n1)admin");


            Console.WriteLine("2)Customer");

            Console.WriteLine("3)Exit");


            option = Console.ReadLine();
            return option;
        }
        static string Menu()
        {

            string option;
            Console.WriteLine("Choose you want to do.... ");


            Console.WriteLine("1) Add Book");

            Console.WriteLine("2) Search By Name");

            Console.WriteLine("3) Search By ISBN");


            Console.WriteLine("4) Update Copies of Books ");


            Console.WriteLine("5) Show All Cash Details");


            Console.WriteLine("6) Search Member by Name");

            Console.WriteLine("7) Search Member by MAmberID");

            Console.WriteLine("8) Show all Members");

            Console.WriteLine("9) Show all Books");

            Console.WriteLine("10) Exit");

            Console.Write("Enter Your Option (1-5): ");
            option = Console.ReadLine();
            return option;
        }
        static string CustomerMenu()
        {

            string option = "";


            Console.WriteLine("1) IF you are registered as member or Non Member Customer");

            Console.WriteLine("2) Sign Up for Membership");

            Console.WriteLine("3) IF you are Occasionally Customer");

            Console.WriteLine("4) Exit");

            option = Console.ReadLine();
            while (option != "1" && option != "2" && option != "3" && option != "4")
            {


                Console.WriteLine("Wrong Option ");


                Console.WriteLine("Press any Key for enter option again");
                Console.ReadKey();

                option = Console.ReadLine();
            }
            return option;
        }

        static void ADDnonMemberCustomer(List<Member> members)
        {

            string name = "", ID = "";
            int price;
            string[] author = new string[4];

            Console.WriteLine("Member Detailes :");

            Console.Write("Enter Name  :");
            ;
            Console.Write("Enter Money in Bank :");

            name = nameCheck1(0, 0);
            price = numericChec(0, 0);
            int count = 0;
            ID = count.ToString();
            Member member = new Member(name, ID, price);
            members.Add(member);

            Console.WriteLine("Data Added Sucessfully ");

            Console.WriteLine("Press any Key for Further Proccessing");
            Console.ReadKey();
        }
        static string login(List<Member> members, List<Member> memb, ref int X)
        {
            bool result = false;
            int C = 0;

            string name = "", ID = "";
            string[] author = new string[4];

            Console.WriteLine("Member Detailes :");


            Console.Write("Enter Name  :");

            Console.Write("Enter Member ID :");

            name = nameCheck1(0, 0);
            ID = ageChec1(0, 0);
            if (ID == "0")
            {
                foreach (Member member in members)
                {
                    if (member.name == name && member.memberID == ID)
                    {
                        X = C;
                    }
                    C++;
                }
            }
            else
            {
                foreach (Member member in memb)
                {
                    if (member.name == name && member.memberID == ID)
                    {
                        X = C;
                    }
                    C++;
                }
            }
            if (X == -1)
            {

                Console.WriteLine("Your Data not Found");
                Console.WriteLine("Press any key for going back");
                Console.ReadLine();
            }
            return ID;

        }

        static void NonMemberBuy(List<book> books, List<Member> Member, int number)
        {
            int count, x = 0, coun = 0;

            string[] title = new string[1000];
            Member[number].BuyBOOKS(books);
            string option = "";
            while (option == "")
            {
                Console.Write("How many books you want to buy ");
                count = int.Parse(Console.ReadLine());
                for (x = coun; x < (count + coun); x++)
                {
                    Console.Write("Enter title of book" + (x + 1));
                    title[x] = Console.ReadLine();
                }

            }
        }
        static book BookAdd()
        {

            string title = "", ISBN = "", publisher = "";
            int stock, year;
            int productprize = 0;
            string[] author = new string[4];

            Console.WriteLine("Book Detailes :");

            Console.Write("Enter Title  :");

            Console.Write("Enter Authors name :");
            for (int i = 0; i < 4; i++)
            {

                Console.Write("author" + (i + 1));
            }

            Console.Write("Enter Prize :");

            Console.Write("Enter Stock :");

            Console.Write("Enter ISBN Code :");

            Console.Write("Enter Year :");

            Console.Write("Enter Publisher :");

            title = nameCheck1(0, 0);

            for (int i = 0; i < 4; i++)
            {
                author[i] = nameCheck1(0, 0);
            }
            productprize = numericChec(0, 0);
            stock = numericChec(0, 0);
            ISBN = numberChec1(0, 0);
            year = numericChec(0, 0);
            publisher = nameCheck1(0, 0);
            book books = new book(title, author, publisher, ISBN, productprize, stock, year);
            return books;

        }
        static void BookSearchbyName(List<book> books)
        {
            string name;

            int X = -1;

            Console.Write("Write the  title of Book   :");
            name = Console.ReadLine();
            foreach (book book in books)
            {
                if (name == book.title)
                {
                    int lY = 0, lX = 0;

                    book.output(lX, lY);
                    
                }
                else
                {

                    Console.WriteLine("This Book is not Availible ");

                    Console.WriteLine("Press any Key for Going back");
                    Console.ReadKey();
                }
            }
        }
        static void DisplayBook(List<book> books)
        {
            int i = 0;

            Console.Write("title" + "author1" + "author2" + "author3" + "author4" + "Price" + "Stock" + "Year" + "ISBN" + "Publisher");
            foreach (book book in books)
            {

                int lY = 0, lX = 0;

                book.output(lX , lY);
                i++;
            }

            Console.WriteLine("Press any Key for Going back");
            Console.ReadKey();



        }
        static void DisplayMembers(List<Member> members, List<Member> nonmember)
        {
            int i = 0;


            Console.Write("name" + "Member ID" + "Money in Bank" + "Membership fee" + "no of buy Books" + "Discound" + "Benifit" + "Total amount for books");
            foreach (Member member in members)
            {
                int lY=0, lX=0;

                member.diaplay(lX - 15, lY + 5 + i, "0%");
                i++;
            }
            foreach (Member member in nonmember)
            {
                int lY = 0, lX = 0;

                member.diaplay(lX - 15, lY + 5 + i, "0%");
                i++;
            }
        
    
         
            
            Console.WriteLine("Press any Key for Going back");
            Console.ReadKey();
          

        }
        static void MemberSearchbyName(List<Member> members)
        {
            string name;

            int X = -1;
          
            Console.Write("Write the   name of Member   :");
            name = Console.ReadLine();
           
            }
        
        static void MemberSearchbyID(List<Member> members)
        {
            string name;
          
            int X = -1;
           
            Console.Write("Write the   ID of Member   :");
            name = Console.ReadLine();
            foreach (Member Members in members)
            {
                if (name == Members.memberID)
                {
                    Members.output(0,0);
                }
                else
                {
                   
                    Console.WriteLine("This  name is not  found ");
                    
                    Console.WriteLine("Press any Key for Going back");
                    Console.ReadKey();
                }
            }
        }
        static void Update(List<book> books)
        {
            string name;
          
            int X = -1;
            
            Console.Write("Write the  title of Book   :");
            name = Console.ReadLine();
            foreach (book book in books)
            {
                if (name == book.title)
                {
                    Console.WriteLine("Enter updated STock of book");
                    book.stock = int.Parse(Console.ReadLine());
                }
                else
                {
                   
                    Console.WriteLine("This Book is not Availible ");
                  
                    Console.WriteLine("Press any Key for Going back");
                    Console.ReadKey();
                }
            }
        }
        static void BookSearchbyISBN(List<book> books)
        {
            string name;
            int X = -1;
 
            Console.Write("Write the   ISBN of Book   :");
            name = Console.ReadLine();
            foreach (book book in books)
            {
                if (name == book.ISBN)
                {
                    book.output(0,0);
                }
                else
                {
                   
                    Console.WriteLine("This Book is not Availible ");
                 
                    Console.WriteLine("Press any Key for Going back");
                    Console.ReadKey();
                }
            }
        }
        static void AddMember(List<Member> memb)
        {
          
            Console.WriteLine("You should Pay RS {0} yearly as membership fee ", 279 * 5);
           
            Console.WriteLine("Press any Key for Further Proccessing");
            Console.ReadKey();
         
            string name = "", ID = "";
            int price;
            string[] author = new string[4];
           
            Console.WriteLine("Member Detailes :");
           
            Console.Write("Enter Name  :");
         
            Console.Write("Enter Money in Bank :");
          
            name = nameCheck1(0,0);
            price = numericChec(0,0);
            int count = memb.Count + 1;
            ID = count.ToString();
            if (price > 279 * 10)
            {
                price -= 279 * 3;
                Member members = new Member(name, ID, price, 279 * 5);
                memb.Add(members);
                TotalAmount += 279 * 3;
                
           
                Console.WriteLine("Rs 1395 deducted from your account");
               
                Console.WriteLine("Account Created Sucessfully ");
              
              
                Console.WriteLine("Your Member ID is  " + ID);
              
                Console.WriteLine("Press any Key for Further Proccessing");
                Console.ReadKey();

            }
            else
            {
               
                Console.WriteLine("Account not created as balance is less than  {0}", 5 * 279);
      
                Console.WriteLine("Press any Key for Further Proccessing");
                Console.ReadKey();

            }
        }
        static string nameCheck1(int x, int y)
        {
            string name;
            name = Console.ReadLine();
            while (isDomicileCheck2(name))
            {
             
                Console.WriteLine("WRONG DATA PLEASE ENTER CORRECT NAME  ");
             
                Console.WriteLine("Press any key for going back  ");
                Console.ReadKey();
                
                name = Console.ReadLine();
            }
            return name;
        }
        
        static string ageChec1(int x, int y)
        {
            string age;
            
            age = Console.ReadLine();
            while (isCnicCheck(age) || age.Length > 2)
            {
               
                Console.WriteLine("WRONG DATA PLEASE ENTER CORRECT AGE ");
                
                Console.WriteLine("Press any key for going back  ");
                Console.ReadKey();
               
                age = Console.ReadLine();
            }
            return age;
        }
        static string numberChec1(int x, int y)
        {
            string phone;
           
            phone = Console.ReadLine();
            while ((phone.Length < 11 || phone.Length > 11) || isCnicCheck(phone))
            {
         
                Console.WriteLine("WRONG DATA PLEASE ENTER YOUR GENDER FROM GIVEN OPTIONS  ");
            
                Console.WriteLine("Press any key for going back  ");
                Console.ReadKey();
                
                phone = Console.ReadLine();
            }
            return phone;
        }
  
        

     
        static bool isCnicCheck(string word)
        {
            int coun;
            coun = word.Length;
            bool result = true;
            int length = 0;
            for (int x = 0; x < coun; x = x + 1)
            {
                if (word[x] >= '0' && word[x] <= '9')
                {
                    length = length + 1;
                }
            }
            if (length == coun)
            {
                result = false;
            }
            return result;
        }
        static bool isDomicileCheck2(string word)
        {
            int coun;
            coun = word.Length;
            bool result = true;
            int length = 0;
            for (int x = 0; x < coun; x = x + 1)
            {
                if (word[x] == '1' || word[x] == '0' || word[x] == '2' || word[x] == '3' || word[x] == '4' || word[x] == '5' || word[x] == '6' || word[x] == '7' || word[x] == '8' || word[x] == '9' || word[x] == '!' || word[x] == '@' || word[x] == '#' || word[x] == '%' || word[x] == '$' || word[x] == '(' || word[x] == ')' || word[x] == '*' || word[x] == '^' || word[x] == '+' || word[x] == '-')
                {
                    length = length + 1;
                }
            }
            if (length == 0)
            {
                result = false;
            }
            return result;
        }
        static int numericChec(int x, int y)
        {
            string phone;
       
            phone = Console.ReadLine();
            while (isCnicCheck(phone))
            {
               
                 Console.WriteLine("please enter data in correct format ");
               
                Console.WriteLine("Press any key for going back  ");
                Console.ReadKey();
                
                phone = Console.ReadLine();
            }

            return int.Parse(phone);
        }
    }
}
