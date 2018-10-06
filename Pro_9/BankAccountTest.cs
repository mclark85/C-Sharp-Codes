/*Matt Clark
 *Program 9 Due: March 13, 2018
 *Blaine Smith
 *This program will ask the user information regarding starting a bank account.  It will save that information and modify it based on the user's inputs and will print out the current information when requested.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MClark_Prog9
{
    class BankAccountTest
    {
        static void Main(string[] args)
        {
            int uChoice;
            bool loop;

            BankAccount newAccount = new BankAccount();
            string typeOfAccount = "";
            int choice = 0;
            decimal amtDorW = 0;
            bool update = false;

            Greeting();
            DisplayMenu();
            choice = GetChoice();
            CheckChoice(choice, out uChoice, out loop);
            while (loop == true)
            {

                switch (uChoice)
                {
                    case 1:
                        newAccount = CreateAccount();

                        break;
                    case 2:
                        typeOfAccount = "Deposit";
                        update = true;
                        amtDorW = GetAmount(typeOfAccount);
                        newAccount.UpdateBalance(amtDorW, update);

                        break;
                    case 3:
                        typeOfAccount = "Withdraw";
                        update = false;
                        amtDorW = GetAmount(typeOfAccount);
                        newAccount.UpdateBalance(amtDorW, update);

                        break;
                    case 4:
                        WriteLine("Your balance is:  {0:C}", newAccount.Balance);

                        break;
                    case 5:
                        WriteLine(newAccount);

                        break;

                }
                DisplayMenu();
                choice = GetChoice();
                CheckChoice(choice, out uChoice, out loop);
            }

        }

        public static void Greeting()
        {
            WriteLine("\nWelcome to Give Us Your Money Bank");
        }

        public static void DisplayMenu()
        {
            WriteLine();
            WriteLine("1) Create New Account");
            WriteLine("2) Deposit");
            WriteLine("3) Withdrawl");
            WriteLine("4) Check Balance");
            WriteLine("5) Print Account");
            WriteLine("6) End Program");
            WriteLine();
        }

        public static int GetChoice()
        {
            Write("Enter the number for your action:  ");
            int choose = int.Parse(ReadLine());
            return choose;
        }

        public static BankAccount CreateAccount()
        {
            Write("\nWhat is the customer's name:  ");
            string name = ReadLine();
            Write("What is the account number:  ");
            int number = int.Parse(ReadLine());
            Write("What is the balance?  ");
            decimal amount = decimal.Parse(ReadLine());
            Write("Is this a savings or checking account?  ");
            string type = ReadLine();
            bool sving = false;
            if (type == "savings" || type == "Savings")
            {
                sving = true;
            }
            BankAccount tempAcc = new BankAccount(name, number, amount, sving);
            return tempAcc;
        }

        public static decimal GetAmount(string type)
        {
            decimal amt = 0;
            if (type == "Deposit")
            {
                Write("How much do you want to deposit?  ");
                amt = decimal.Parse(ReadLine());
                while (amt < 0)
                {
                    WriteLine("Amount needs to be larger than $0.00.");
                    Write("How much do you want to deposit?  ");
                    amt = decimal.Parse(ReadLine());
                }
            }
            else
            {
                Write("How much do you want to withdraw?  ");
                amt = decimal.Parse(ReadLine());
            }
            return amt;
        }

        public static void CheckChoice(int numChoice, out int aChoice, out bool toLoop)
        {

            toLoop = false;
            while (numChoice < 1 || numChoice > 6)
            {
                Write("Not a valid choice.  Try again.\n");
                DisplayMenu();
                numChoice = GetChoice();
            }

            if (numChoice == 1 || numChoice == 2 || numChoice == 3 || numChoice == 4 || numChoice == 5)
            {
                toLoop = true;
            }

            aChoice = numChoice;
        }
    }
}