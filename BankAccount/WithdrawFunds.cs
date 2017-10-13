using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class WithdrawFunds : DepositFunds
    {
        private double checkingAccount;
        private double savingsAccount;

        public WithdrawFunds()
        {

        }

        public WithdrawFunds(string name, int accountNumber)
        {
            this.Name = name;
            this.AccountNumber = accountNumber;
        }

        public WithdrawFunds(double checkingAccount, double savingsAccount)
        {
            this.checkingAccount = checkingAccount;
            this.savingsAccount = savingsAccount;
        }


    }
}
