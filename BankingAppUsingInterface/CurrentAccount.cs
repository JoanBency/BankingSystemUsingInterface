using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppUsingInterface
{
    public class CurrentAccount : IAccount
    {
        public void deposit()
        { }
        public void withdraw()
        { }
        public void getBalance()
        { }
        public void run()
        {
            Console.WriteLine("\t\t\t\t\t\tCurrent Account");
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
