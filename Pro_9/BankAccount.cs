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
    class BankAccount
    {
        private int account;
        private decimal balance;
        private string owner;
        private bool savings;

        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }

        public int Account
        {
            get
            {
                return account;
            }
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
        }

        public bool Savings
        {
            get
            {
                return savings;
            }
            set
            {
                savings = value;
            }
        }

        public BankAccount()
        {
         owner = "Need a name";
           
        }

        public BankAccount(string name, int number, decimal amount, bool sving)
        {
            owner = name;
            savings = sving;
            SetAccount(number);
            UpdateBalance(amount, true);
        }

        public void SetAccount(int num)
        {
            account = num;
            while (account < 0)
            {
                Write("Not an acceptable account nmber.  Enter a new number:  ");
                account = int.Parse(ReadLine());
            }
        }

        public void UpdateBalance(decimal amount, bool deposit)
        {
            if (deposit == true)
            {
                while (amount < 0)
                {
                    Write("Amount may not be less than $0.00.  Enter a new amount to deposit:  ");
                    amount = decimal.Parse(ReadLine());
                }

                balance += amount;
            }
            else
            {
                while (amount > balance)
                {
                    Write("Amount desired is greater than current balance of {0:C}.  Enter new amount to withdraw:  ", balance);
                    amount = decimal.Parse(ReadLine());
                }

                balance -= amount;
            }
        }

        public override string ToString()
        {
            string type = "";
            if (savings == false)
            {
                type = "checking";
            }
            else
            {
                type = "savings";
            }
            return string.Format("\nAccount Information\n\nAccount Number:  {0}\nAccount Owner:  {1}\nBalance:  {2:C}\nThis is a {3} account.", account, owner, balance, type);
        }

    }
}
