using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class ClientInformation
    {
        //Since I'm making the Class Client Information the base class or the Parent Class
        //I decided to start off with simple name and account number to start things off.

        protected string name;
        protected int accountNumber;


        //Getting the private fields to set them in the program when the pc asks the user for there information.

        public string Name { get; set; }
        public int AccountNumber { get; set; }
        

        //Tis is simply the default Constructor that is required to have the other classes inherit
        //from this class since this one is the Parent.

        public ClientInformation()
        {

        }

        //Tis is for the other classes so they are able to get this information in set it in there own class.

        public ClientInformation(string name, int accountNumber)
        {
            this.name = name;
            this.accountNumber = accountNumber;
        }

        public virtual void  ClientInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Account Number: " + accountNumber);
            
        }
    }
}
