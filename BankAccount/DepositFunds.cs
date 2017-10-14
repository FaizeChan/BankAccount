using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class DepositFunds : ClientInformation
    {
        private double checkingAccount;
        private double savingsAccount;

        public double CheckingAccount { get; set; }
        public double SavingsAccount { get; set; }

        public DepositFunds()
        {

        }

        public DepositFunds(string name, int accountNumber)
        {
            this.Name = name;
            this.AccountNumber = accountNumber;
        }

        public DepositFunds(double checkingAccount, double savingsAccount)
        {
            this.checkingAccount = checkingAccount;
            this.savingsAccount = savingsAccount;
        }

        public virtual void Deposit()
        {
            Console.WriteLine("Current Checkings Balance: " + checkingBalance);
            Console.WriteLine("Current Savings Balance: " + savingsBalance);
        }

    }
}
