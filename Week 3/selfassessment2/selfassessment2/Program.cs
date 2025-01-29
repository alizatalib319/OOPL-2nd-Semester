using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selfassessment2
{ 
    public class Program
    {
        
        static void Main(string[] args)
        {
            int option;
            calculator calculate = new calculator();
            Console.WriteLine("Enter Value 1: ");
            calculate.Value1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value 2:");
            calculate.Value2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter what you want to perform(1.add,2.sub,3.mul,4.div): ");
            option=int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int a=calculate.Addition();
                    Console.WriteLine(a);
                        
                    break;
                case 2:
                    Console.WriteLine(calculate.Subtraction()); 
                    break;
                case 3:
                    Console.WriteLine(calculate.Division());
                    break;
                case 4:
                    Console.WriteLine(calculate.Multiplication());
                    break;
            }

        }
    }
}
