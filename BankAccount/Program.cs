using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            //do while loop is needed to restart the program

            Console.WriteLine("Welcome to The United Banks. \nTo start press one of the following numbers displayed");
            Console.WriteLine();

            Console.WriteLine("[1] View Client Information");
            Console.WriteLine("[2] View Account Balance");
            Console.WriteLine("[3] Deposit Funds");
            Console.WriteLine("[4] Withdraw Funds");
            Console.WriteLine("[5] Exit");
            int userChoice = int.Parse(Console.ReadLine().Trim());
            int one = 1;
            int two = 2;
            int three = 3;
            int four = 4;
            int five = 5;

            if (userChoice == one)
            {
                ClientInformation Info = new ClientInformation("Faizon Alexander", 03091996);
                Info.ClientInfo();
            }
            else if (userChoice == two)
            {
                AccountBalance Balance = new AccountBalance(250.75d, 300.25d);
                Balance.ClientBalance();
            }
            else if (userChoice == three)
            {
                DepositFunds Deposit = new DepositFunds()
            }
        }
    }
}
