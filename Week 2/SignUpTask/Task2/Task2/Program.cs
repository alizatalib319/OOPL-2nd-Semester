using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Task2
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string path = "C:\\Users\\YCS\\source\\repos\\New folder\\Task2\\data.txt";
                string[] user = new string[10];
                string[] password = new string[10];
                string[] roles = new string[10];
                int option;
                do
                {
                    readData(path, user, password, roles);
                    Console.Clear();
                    option = MainMenu();
                    Console.Clear();
                    if (option == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("********************************************");
                        Console.WriteLine("*                 Sign Up                  *");
                        Console.WriteLine("********************************************");
                        Console.WriteLine("Enter User-ID:");
                        string n = Console.ReadLine();
                        Console.WriteLine("Enter Password:");
                        string p = Console.ReadLine();
                        SignUp(path, n, p);
                        readData(path, user, password, roles);
                    }
                    else if (option == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("********************************************");
                        Console.WriteLine("*                  Log In                  *");
                        Console.WriteLine("********************************************");
                        Console.WriteLine("Enter User-ID:");
                        string n = Console.ReadLine();
                        Console.WriteLine("Enter Password:");
                        string p = Console.ReadLine();
                        SignIn(n, p, user, password);
                    }
                } while (option != 3);
            }
            static int MainMenu()
            {
                int option;
                Console.WriteLine("********************************************");
                Console.WriteLine("*                Main Menu                 *");
                Console.WriteLine("********************************************");
                Console.WriteLine("              1.Sign Up");
                Console.WriteLine("              2.Log In");
                Console.WriteLine("               3.Exit");
                Console.WriteLine("            Your Option");
                option = int.Parse(Console.ReadLine());
                return option;
            }
            static string parseData(string record, int field)
            {
                int comma = 1;
                string item = "";
                for (int x = 0; x < record.Length; x++)
                {
                    if (record[x] == ',')
                    {
                        comma++;
                    }
                    else if (comma == field)
                    {
                        item = item + record[x];
                    }
                }
                return item;
            }
            static void readData(string path, string[] user, string[] password, string[] roles)
            {
                int x = 0;
                if (File.Exists(path))
                {
                    StreamReader fileVariable = new StreamReader(path);
                    string record;
                    while ((record = fileVariable.ReadLine()) != null)
                    {
                        user[x] = parseData(record, 1);
                        password[x] = parseData(record, 2);
                        roles[x] = parseData(record, 3);
                        x++;
                        if (x >= 10)
                        {
                            break;
                        }
                    }
                    fileVariable.Close();
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            static bool ValidatePassword(string password)
            {
                if (password.Length < 6)
                {
                    return false;
                }

                for (int i = 0; i < password.Length; i++)
                {
                    if (password[i] == ' ')
                    {
                        Console.WriteLine("Spaces detected");
                        password = Console.ReadLine();
                        i = -1;
                    }
                }
                return true;
            }
            static void SignUp(string path, string n, string p)
            {

                string role;
                bool isValidPassword = false;
                while (!isValidPassword)
                {
                    if (ValidatePassword(p))
                    {
                        isValidPassword = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Password Format. Please enter a new password:");
                        p = Console.ReadLine();

                    }
                }
                Console.WriteLine("Your Role (As Admin/Customer):");
                role = Console.ReadLine();
                StreamWriter file = new StreamWriter(path, true);
                file.WriteLine(n + "," + p + "," + role);
                file.Flush();
                file.Close();
            }
            static void SignIn(string n, string p, string[] user, string[] password)
            {
                bool userFound = false;
                for (int i = 0; i < 5; i++)
                {
                    if (user[i] == n && password[i] == p)
                    {
                        Console.WriteLine("Valid User");
                        userFound = true;
                        break;
                    }
                }
                if (!userFound)
                {
                    Console.WriteLine("Invalid User");
                }
                Console.ReadKey();
            }
        }
    }

