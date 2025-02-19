using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selfassessment1
{
    public class Transactions
    {
        public string ProductName;
        public int TransactionId;
        public float Amount;
        public string DateTime;
    

   
        public void PrintTrans()
        {
            Console.WriteLine($"Your TransactionID is {TransactionId}\nProductName is {ProductName}\nDate & Time for the Transaction is {DateTime}\nYour total Amount is {Amount}");

        }


    }
}
