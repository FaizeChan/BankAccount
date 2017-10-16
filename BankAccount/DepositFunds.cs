using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class DepositFunds : AccountBalance
    {
        private double checkingAccount;
        private double savingsAccount;

        public double CheckingAccount { get; set; }
        public double SavingsAccount { get; set; }
        public double DepositMoney { get; set; }

        public DepositFunds()
        {

        }

        public DepositFunds(double checkingAccount, double savingsAccount)
        {
            this.checkingAccount = checkingAccount;
            this.savingsAccount = savingsAccount;
        }

        public DepositFunds(double DepositMoney)
        {
            this.DepositMoney = DepositMoney;
        }

        public void CheckDepositting()
        {
            checkingAccount += double.Parse(Console.ReadLine());
            Console.WriteLine("Your total Amount in your checking account is {0}.", checkingAccount);
        }

    }
}
