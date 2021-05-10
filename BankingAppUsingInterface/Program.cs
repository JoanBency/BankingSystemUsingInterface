using System;

namespace BankingAppUsingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\tBanking System");
            Console.WriteLine("\n1.Current Account\n2.Savings Account\n3.Recurrent Account\nChoose your account type(1-3)");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1" : CurrentAccount CA = new CurrentAccount();
                    CA.run();
                    break;
                case "2" : SavingsAccount SA = new SavingsAccount();
                    SA.run();
                    break;
                case "3" : RecurrentAccount RA = new RecurrentAccount();
                    RA.run();
                    break;
                default : Console.WriteLine("Wrong Choice!!!!!");
                    break;
            }
        }
    }
}
