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

            //do while loop is needed to restart the program until break in [5] Exit
            string playAgain = "";

            do
            {
                Console.WriteLine("Welcome to The United Banks. \nTo start press one of the following numbers displayed");
                Console.WriteLine();

                //Tis is the simple part. Just putting in Console writeline to make the
                //user understand what they have to do. Simply press 1 through 5

                Console.WriteLine("[1] View Client Information");
                Console.WriteLine("[2] View Account Balance");
                Console.WriteLine("[3] Deposit Funds");
                Console.WriteLine("[4] Withdraw Funds");
                Console.WriteLine("[5] Exit");

                //Learn this stuff day one. There are most likely loops for this but my mind
                //completely zoned them out and I went back to the basics and stuck to the 
                //stuff I was most comfortable with.

                int userChoice = int.Parse(Console.ReadLine().Trim());
                int one = 1;
                int two = 2;
                int three = 3;
                int four = 4;
                int five = 5;

                //made a couple if else statements to declare on the choices the user was going
                //to pick and depending on the decision then a specific outcome will happen.
                if (userChoice == one)
                {
                    ClientInformation Info = new ClientInformation("Faizon Alexander", 03091996);
                    Info.ClientInfo();
                }

                //I believe the Methods were accurate and the more I did the more simple it got.

                else if (userChoice == two)
                {
                    AccountBalance Balance = new AccountBalance(500.75d, 375.25d);
                    Balance.ClientBalance();
                }
                else if (userChoice == three)
                {
                    Console.WriteLine("[a] To Checking Account \n[b] To Savings Account");
                    string usrChoice = Console.ReadLine().ToLower();
                    string a = "a";
                    string b = "b";
                    if (usrChoice == a)
                    {
                    DepositFunds Depo = new DepositFunds();
                    Console.WriteLine("How much money would you like to deposit into your Checking Account?");
                    Depo.CheckDepositting();
                    }
                    else if (usrChoice == b)
                    {
                    DepositFunds Depo = new DepositFunds();
                    Console.WriteLine("How much money would you like to deposit into your Savings Account?");

                    }
                }
                else if (userChoice == four)
                {
                    Console.WriteLine("[a] Checking Account \n[b] Savings Account");
                    string usrChoice = Console.ReadLine().ToLower();
                }
                else if (userChoice == five)
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank you for choosing The United Banks.");
                    break;
                }

                //For choice number 5 which is the quit. I had the break take place since
                //the whole program class is in a loop which will have the user exit the system.

                else
                {
                Console.WriteLine("Invalid input. Back to main menu.");
                }

                //didn't really need to work hard on a invalid input because since it's already
                //in a loop all I needed to say was back to main menu/ beginning because thats exactly where
                //the computer was going to take the user.

                playAgain = Console.ReadLine().ToLower();
            } while (playAgain == "");
        }
    }
}

