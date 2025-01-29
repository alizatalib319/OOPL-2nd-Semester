using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selfassessment1
{
    public class Program
    {
        string product;
        static void Main(string[] args)
        { Transactions trans=new Transactions();
            Console.WriteLine("Enter Product Name");
            trans.ProductName = Console.ReadLine();
            trans.Amount = 1000;
            trans.DateTime = "2-2-23";
            trans.TransactionId = 101;
            trans.PrintTrans();

                
        }
    }
}
