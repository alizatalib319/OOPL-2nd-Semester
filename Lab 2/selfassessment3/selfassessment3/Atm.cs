using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace selfassessment3
{
    public class Atm
    {
        public double Amount=100;
        public double Balance;
        public const int max_size = 5;
        public double[] withdrawhistory = new double[max_size];
        public int with_historycount = 0;
        public double[] deposithistory = new double[max_size];
        public int depo_historycount = 0;
        public bool deposit = false;
        public bool withdraw = false;

        public double Withdraw()
        {   if (Balance <= Amount)
            {
                Amount = Amount - Balance;
                withdrawhistory[with_historycount++] = Balance;
                withdraw = true;
                Balance = 0;
                return Amount;



            }
            else
            {
                Console.WriteLine("Failed......you are trying to withdraw more than in account"); 
                return 0;
            }

        }
        public void TransactionHistory()
        {   string option1;
            Console.WriteLine("Do You want to check your history(yes/no)...?");
            option1=(Console.ReadLine());
            switch(option1)
            {
                case "yes":
                    if (withdraw)
                    {
                        for (int i = 0; i < with_historycount; i++)
                        {

                            Console.WriteLine($"You have withdrawn {withdrawhistory[i]} balance in your account ");


                        }
                    }

                    if (deposit)
                    {
                        for (int i = 0; i<depo_historycount; i++)
                        {
                            Console.WriteLine($"You have deposited {deposithistory[i]} balance from your account ");
                        }
                    }
                   

                    break;
                case "no":
                    Console.Write("Request Cancel");
                    break;

            }
            
        }
        public double CurrentBalance()
        {
            return Amount;
        }
        public double Deposit()
        {
            
            Amount = Balance + Amount;
            deposithistory[depo_historycount++] = Balance;
            Balance = 0;
            deposit = true;
            return Amount;
            
        }
    }
}
