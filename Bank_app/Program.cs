using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(1, "Ashmit", 500);
            Customer c2 = new Customer(2, "Anand", 500);
            Customer c3 = new Customer(3, "Kumar", 500);

            Customer c4 = new Customer(4, "Sharma", 500);
            Customer c5 = new Customer(5, "Ashok", 500);

            Customer c6 = new Customer(6, "Ankit", 500);
            Customer c7 = new Customer(7, "Ramesh", 500);
            Customer c8 = new Customer(8, "Suresh", 500);
            Customer c9 = new Customer(9, "Neta", 500);
            Customer c10 = new Customer(10, "Modi", 500);

            Console.WriteLine("Enter your Customer ID");
            int cid = int.Parse(Console.ReadLine());

            switch (cid)
            {
                case 1:
                    Console.WriteLine("Hi " + c1.name + ", Your Opening Balance is " + c1.opening_balance);

                    Console.WriteLine("Press 1 to Deposite\t Press 2 to Withdrawn");
                    int input1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (input1 == 1)
                    {
                        Console.WriteLine("Enter the amount to Deposite");
                        int amount = int.Parse(Console.ReadLine());
                        c1.deposite(amount);
                        Console.WriteLine("Total Balance " + c1.opening_balance);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Enter the amount to Withdrawn");
                        int amount = int.Parse(Console.ReadLine());

                        if (c1.opening_balance < amount)
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                        if (c1.opening_balance > amount)
                        {
                            c1.withdrawn(amount);
                        }
                        Console.WriteLine("Remaining Balance " + c1.opening_balance);
                        Console.ReadLine();

                    }
                    break;
                case 2:
                    Console.WriteLine("Hi " + c2.name + ", Your Opening Balance is " + c2.opening_balance);
                    Console.WriteLine("Press 1 to Deposite\t Press 2 to Withdrawn");
                    int input2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (input2 == 1)
                    {
                        Console.WriteLine("Enter the amount to Deposite");
                        int amount = int.Parse(Console.ReadLine());
                        c2.deposite(amount);
                        Console.WriteLine("Total Balance " + c2.opening_balance);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Enter the amount to Withdrawn");
                        int amount = int.Parse(Console.ReadLine());

                        if (c2.opening_balance < amount)
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                        if (c2.opening_balance > amount)
                        {
                            c2.withdrawn(amount);
                        }
                        Console.WriteLine("Remaining Balance " + c2.opening_balance);
                        Console.ReadLine();

                    }
                    break;
                case 3:
                    Console.WriteLine("Hi " + c3.name + ", Your Opening Balance is " + c3.opening_balance);
                    Console.WriteLine("Press 1 to Deposite\t Press 2 to Withdrawn");
                    int input3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (input3 == 1)
                    {
                        Console.WriteLine("Enter the amount to Deposite");
                        int amount = int.Parse(Console.ReadLine());
                        c3.deposite(amount);
                        Console.WriteLine("Total Balance " + c3.opening_balance);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Enter the amount to Withdrawn");
                        int amount = int.Parse(Console.ReadLine());

                        if (c3.opening_balance < amount)
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                        if (c3.opening_balance > amount)
                        {
                            c1.withdrawn(amount);
                        }
                        Console.WriteLine("Remaining Balance " + c3.opening_balance);
                        Console.ReadLine();

                    }
                    break;
                case 4:
                    Console.WriteLine("Hi " + c4.name + ", Your Opening Balance is " + c4.opening_balance);
                    Console.WriteLine("Press 1 to Deposite\t Press 2 to Withdrawn");
                    int input4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (input4 == 1)
                    {
                        Console.WriteLine("Enter the amount to Deposite");
                        int amount = int.Parse(Console.ReadLine());
                        c4.deposite(amount);
                        Console.WriteLine("Total Balance " + c4.opening_balance);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Enter the amount to Withdrawn");
                        int amount = int.Parse(Console.ReadLine());

                        if (c4.opening_balance < amount)
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                        if (c4.opening_balance > amount)
                        {
                            c4.withdrawn(amount);
                        }
                        Console.WriteLine("Remaining Balance " + c4.opening_balance);
                        Console.ReadLine();

                    }
                    break;
                case 5:
                    Console.WriteLine("Hi " + c5.name + ", Your Opening Balance is " + c5.opening_balance);
                    Console.WriteLine("Press 1 to Deposite\t Press 2 to Withdrawn");
                    int input5 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (input5 == 1)
                    {
                        Console.WriteLine("Enter the amount to Deposite");
                        int amount = int.Parse(Console.ReadLine());
                        c5.deposite(amount);
                        Console.WriteLine("Total Balance " + c5.opening_balance);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Enter the amount to Withdrawn");
                        int amount = int.Parse(Console.ReadLine());

                        if (c5.opening_balance < amount)
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                        if (c5.opening_balance > amount)
                        {
                            c5.withdrawn(amount);
                        }
                        Console.WriteLine("Remaining Balance " + c5.opening_balance);
                        Console.ReadLine();

                    }
                    break;
                case 6:
                    Console.WriteLine("Hi " + c6.name + ", Your Opening Balance is " + c6.opening_balance);
                    Console.WriteLine("Press 1 to Deposite\t Press 2 to Withdrawn");
                    int input6 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (input6 == 1)
                    {
                        Console.WriteLine("Enter the amount to Deposite");
                        int amount = int.Parse(Console.ReadLine());
                        c6.deposite(amount);
                        Console.WriteLine("Total Balance " + c6.opening_balance);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Enter the amount to Withdrawn");
                        int amount = int.Parse(Console.ReadLine());

                        if (c6.opening_balance < amount)
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                        if (c6.opening_balance > amount)
                        {
                            c6.withdrawn(amount);
                        }
                        Console.WriteLine("Remaining Balance " + c6.opening_balance);
                        Console.ReadLine();

                    }
                    break;
                case 7:
                    Console.WriteLine("Hi " + c7.name + ", Your Opening Balance is " + c7.opening_balance);
                    Console.WriteLine("Press 1 to Deposite\t Press 2 to Withdrawn");
                    int input7 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (input7 == 1)
                    {
                        Console.WriteLine("Enter the amount to Deposite");
                        int amount = int.Parse(Console.ReadLine());
                        c7.deposite(amount);
                        Console.WriteLine("Total Balance " + c7.opening_balance);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Enter the amount to Withdrawn");
                        int amount = int.Parse(Console.ReadLine());

                        if (c7.opening_balance < amount)
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                        if (c7.opening_balance > amount)
                        {
                            c7.withdrawn(amount);
                        }
                        Console.WriteLine("Remaining Balance " + c7.opening_balance);
                        Console.ReadLine();

                    }
                    break;
                case 8:
                    Console.WriteLine("Hi " + c8.name + ", Your Opening Balance is " + c8.opening_balance);
                    Console.WriteLine("Press 1 to Deposite\t Press 2 to Withdrawn");
                    int input8 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (input8 == 1)
                    {
                        Console.WriteLine("Enter the amount to Deposite");
                        int amount = int.Parse(Console.ReadLine());
                        c8.deposite(amount);
                        Console.WriteLine("Total Balance " + c1.opening_balance);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Enter the amount to Withdrawn");
                        int amount = int.Parse(Console.ReadLine());

                        if (c8.opening_balance < amount)
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                        if (c8.opening_balance > amount)
                        {
                            c8.withdrawn(amount);
                        }
                        Console.WriteLine("Remaining Balance " + c8.opening_balance);
                        Console.ReadLine();

                    }
                    break;
                case 9:
                    Console.WriteLine("Hi " + c9.name + ", Your Opening Balance is " + c9.opening_balance);
                    Console.WriteLine("Press 1 to Deposite\t Press 2 to Withdrawn");
                    int input9 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (input9 == 1)
                    {
                        Console.WriteLine("Enter the amount to Deposite");
                        int amount = int.Parse(Console.ReadLine());
                        c9.deposite(amount);
                        Console.WriteLine("Total Balance " + c9.opening_balance);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Enter the amount to Withdrawn");
                        int amount = int.Parse(Console.ReadLine());

                        if (c9.opening_balance < amount)
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                        if (c9.opening_balance > amount)
                        {
                            c9.withdrawn(amount);
                        }
                        Console.WriteLine("Remaining Balance " + c9.opening_balance);
                        Console.ReadLine();

                    }
                    break;
                case 10:
                    Console.WriteLine("Hi " + c10.name + ", Your Opening Balance is " + c10.opening_balance);
                    Console.WriteLine("Press 1 to Deposite\t Press 2 to Withdrawn");
                    int input10 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (input10 == 1)
                    {
                        Console.WriteLine("Enter the amount to Deposite");
                        int amount = int.Parse(Console.ReadLine());
                        c10.deposite(amount);
                        Console.WriteLine("Total Balance " + c10.opening_balance);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Enter the amount to Withdrawn");
                        int amount = int.Parse(Console.ReadLine());

                        if (c10.opening_balance < amount)
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                        if (c1.opening_balance > amount)
                        {
                            c10.withdrawn(amount);
                        }
                        Console.WriteLine("Remaining Balance " + c10.opening_balance);
                        Console.ReadLine();

                    }
                    break;
                default:
                    Console.WriteLine("Customer ID does not exists");
                    Console.ReadLine();
                    break;

            }


        }
    }
}

       
  
