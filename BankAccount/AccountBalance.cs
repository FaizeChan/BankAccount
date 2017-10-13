using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class AccountBalance : ClientInformation
    {
        private double checkingBalance;
        private double savingsBalance;

        //I'm only getting Checking and savings from this class because this isnt the right class to take
        //money out off or to put money in.
        //It's only to see how much money you have in these 2 accounts. Unable to change.

        public double CheckingBalance { get; }
        public double SavingsBalance { get; }

        public AccountBalance()
        {

        }

        public AccountBalance(string name, int accountNumber)
        {
            this.Name = name;
            this.AccountNumber = accountNumber;
        }

        public AccountBalance(double checkingBalance, double savingsBalance)
        {
            //these fields are in this class
            this.checkingBalance = checkingBalance;
            this.savingsBalance = savingsBalance;
        }

        public virtual void ClientBalance()
        {
            Console.WriteLine("Checking Balance: " + checkingBalance);
            Console.WriteLine("Savings Balance: " + savingsBalance);
        }

    }
}
