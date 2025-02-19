using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab4
{
    internal class Member
    {
        public string name;
        public string memberID;
        public int Listofbooksbought;
        public int numberofbooksbought;
        public float moneyInBank;
        public int amountspent;
        public float buyBookMiney;
        public float benifit;
        public List<book> BOOKS = new List<book>();
        public Member(string name, string memberID, float moneyInBank, int amountspent)
        {
            this.name = name;
            this.memberID = memberID;
            this.numberofbooksbought = 0;
            this.moneyInBank = moneyInBank;
            this.amountspent = amountspent;
            this.benifit = 0;
            this.buyBookMiney = 0;
        }
        public void processCompleted(string[] title, string amount, List<book> books)
        {
            moneyInBank -= float.Parse(amount);
            buyBookMiney += float.Parse(amount);
            List<int> num = new List<int>();
            for (int i = 0; i < title.Length; i++)
            {
                for (int j = 0; j < books.Count; j++)
                {
                    if (title[i] == books[j].title)
                    {
                        num.Add(j);
                    }
                }
            }
            foreach (int i in num)
            {
                BOOKS.Add(books[i]);
            }
            numberofbooksbought += num.Count;

        }
        public void BuyBOOKS(List<book> books)
        {
            
           
            Console.WriteLine("Sr No" + "title" + "author1" + "author2" + "author3" + "author4" + "Price"+ "Stock" + "Year"+ "ISBN" + "Publisher");
            
        }
        public Member(string name, string memberID, int moneyInBank)
        {
            this.name = name;
            this.memberID = memberID;
            this.numberofbooksbought = 0;
            this.moneyInBank = moneyInBank;
            this.amountspent = 0;
            this.benifit = 0;
            this.buyBookMiney = 0;
        }
        public float cart(string[] title, List<book> books)
        {
            float price = 0;
            int lX = 30, lY = 13;
            List<int> num = new List<int>();
            for (int i = 0; i < title.Length; i++)
            {
                for (int j = 0; j < books.Count; j++)
                {
                    if (title[i] == books[j].title)
                    {
                        num.Add(j);
                    }
                }
            }
           
            Console.WriteLine("Title" + "Price" + "Discound" + " Tax"+ "Price After Discound");
            for (int x = 0; x < num.Count; x++)
            {
                price += books[x].price;
                
            }
            Console.WriteLine();
            return price;
        }
        public float cart1(string[] title, List<book> books)
        {
            float price = 0;
            int lX = 30, lY = 13;
            List<int> num = new List<int>();
            for (int i = 0; i < title.Length; i++)
            {
                for (int j = 0; j < books.Count; j++)
                {
                    if (title[i] == books[j].title)
                    {
                        num.Add(j);
                    }
                }
            }
         
            Console.WriteLine("Title" + "Price" + "Discound" + "Tax" + "Price After Discound");
            for (int x = 0; x < num.Count; x++)
            {
                benifit += ((books[x].price) * 0.1F);
                price += ((books[x].price) * 0.9F);
                Thread.Sleep(80);
                books[x].salebook();
            }
            Console.WriteLine();
            return price;
        }
        public void output(int x, int y)
        {
            int i = 0;
         
            Console.WriteLine("name" + name);
         
            Console.WriteLine(("Member ID" + memberID));
         
            Console.WriteLine("Money in Bank "+ moneyInBank.ToString());
            
          
            Console.WriteLine("Amount Spent" + amountspent.ToString());
          
            Console.WriteLine(("Number of Books Bought" + numberofbooksbought.ToString()));
           
            Console.WriteLine(("Amount spent for buy book" + buyBookMiney.ToString())); 
          
            Console.WriteLine(("Benefit Against Membership fee" + benifit.ToString()));
            if (numberofbooksbought > 0)
            {
               
                Thread.Sleep(50);
                Console.WriteLine("Press 1 for seeing book list or");
              
                Thread.Sleep(50);
                Console.Write("Press any Key for Going back    ");
                string list = Console.ReadLine();
                if (list == "1")
                {
                    
                    Console.WriteLine("Title" + "Price");
                    for (i = 0; i < numberofbooksbought; i++)
                    {
                        Console.WriteLine(BOOKS[i] + BOOKS[i].price.ToString());
                    }
                }
            }
            
            
            Console.WriteLine("Press any Key for Going back");
            Console.ReadKey();
        }
        public void diaplay(int x, int y, string discound)
        {
            
            Console.Write(name);
            Console.Write((memberID));
            Console.Write((moneyInBank.ToString()));
            Console.Write((amountspent.ToString()));
            Console.Write((numberofbooksbought.ToString()));
            Console.Write(discound.ToString());
            Console.Write(benifit.ToString());
            Console.Write(buyBookMiney.ToString());
        }
      
    }
}
