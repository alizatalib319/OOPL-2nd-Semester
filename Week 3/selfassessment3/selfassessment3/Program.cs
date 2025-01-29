using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selfassessment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atm atm = new Atm();
            int option=0;
            while(option!=5)
            {
                Console.Clear();
           
            Console.WriteLine("Select What you want to do: ");
            Console.WriteLine("1.Deposit\n2.Withdraw\n3.View current Account Balance\n4.View Transaction History\n5.Exit");
            option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter money you want to deposit: ");
                        atm.Balance = double.Parse(Console.ReadLine());
                        Console.WriteLine("Your total balance is:");
                        Console.WriteLine(atm.Deposit());
                        break;
                    case 2:
                        Console.WriteLine("Enter How much money you want to withdraw: ");
                        atm.Balance = double.Parse(Console.ReadLine());
                        Console.WriteLine("Your total balance is:");
                        Console.WriteLine(atm.Withdraw());
                        break;
                    case 3:
                        Console.WriteLine("Your current account balance is: ");
                        Console.WriteLine(atm.CurrentBalance());
                        break;
                    case 4:
                        atm.TransactionHistory();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        Console.ReadKey();
                        break;
                }
                Console.WriteLine("press any key");
                Console.ReadKey();
               
            }



            }
        }
    }

