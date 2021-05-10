using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppUsingInterface
{
    public class RecurrentAccount : IAccount
    {
        double amount = 0.0;
        double balance = 0.0;
        public void deposit()
        {
            Console.WriteLine("\nEnter the amount to deposit : ");
            amount = Convert.ToDouble(Console.ReadLine());
            balance = balance + amount;
            Console.WriteLine("Amount Successfully Deposited");
            run();
        }
        public void withdraw()
        {
            if (balance != 0.0)
            {
                Console.WriteLine("\nEnter the amount to withdraw : ");
                amount = Convert.ToDouble(Console.ReadLine());
                balance = balance - amount;
                Console.WriteLine("Amount Successfully Withdrawn");
                run();
            }
            else
            {
                Console.WriteLine("Account is Empty");
                run();
            }
        }
        public void getBalance()
        {
            Console.WriteLine($"Current balance is ${balance}");
            run();
        }
        public void run()
        {
            Console.WriteLine("\n\t\t\t\t\t\tRecurrent Account");
            Console.WriteLine("\n1.Deposit Money\n2.Withdraw Money\n3.Get Balance\nChoose your account type(1-3)");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    deposit();
                    break;
                case "2":
                    withdraw();
                    break;
                case "3":
                    getBalance();
                    break;
                default:
                    Console.WriteLine("Wrong Choice!!!!!");
                    break;
            }
        }
    }
}
