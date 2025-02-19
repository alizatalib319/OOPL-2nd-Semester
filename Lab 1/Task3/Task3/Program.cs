using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, Y;
            Console.Write("Enter minimum price ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minimum Orders");
            Y = int.Parse(Console.ReadLine());
            string path = "C:\\Users\\YCS\\source\\repos\\New folder\\Task3\\pizza.txt";
            StreamReader filevar = new StreamReader(path);
            string record;
            while ((record = filevar.ReadLine()) != null)
            {
                string name = "";
                string order = "";
                string orders = "";
                int[] arr = new int[20];
                int numbers;
                int i = 0;
                int numbercount = 0;
                while (i < record.Length && record[i] != ' ')
                {
                    name = name + record[i];
                    i++;
                }
                i++;
                while (i < record.Length && record[i]!=' ')
                {
                    order = order + record[i];
                    i++;
                }
                int order1 = int.Parse(order);
                i++;
                while (i < record.Length)
                {
                    if (record[i] >= '0' && record[i] <= '9')
                    {
                        while (i < record.Length && record[i] >= '0' && record[i] <= '9')
                        {
                            orders = orders + record[i];
                            i++;
                        }
                        numbers = int.Parse(orders);
                        arr[numbercount++] = numbers;
                        orders = "";
                    }
                    else
                    {
                        i++;
                    }
                    
                }
                bool result;
                result = maxorders(arr, name, order1, N, Y, numbercount);
                if(result)
                {
                    Console.WriteLine($"{name} is eligible");
                }
            }
            filevar.Close();
        }
        static bool maxorders(int[] arr, string name, int order1, int N, int Y, int numbercount)
        {
            bool freepizza = false;
            int count = 0;
            Console.WriteLine(N);
            Console.WriteLine(Y);

            for (int i = 0; i < numbercount; i++)
            {
                if (arr[i] >= N)
                {
                    Console.WriteLine(arr[i]);
                    count++;
                }
            }
            Console.WriteLine(count);
            if (order1 >= Y && count >= Y)
            {
                freepizza = true;
              
            }

            return freepizza;
        }


    }
}
    

