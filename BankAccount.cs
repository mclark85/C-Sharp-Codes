/*Matt Clark
 * Program 5 Due: Feb. 13, 2018
 * Blaine Smith
 * This program will accept two user names and numbers and will then print out their bank acount iformation 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MClark_Prog5
{
    class BankAccount
    {
        private int account;
        private string owner;
        private decimal balance;

        public BankAccount(string owner1, int account1)
        {
            account = account1;
            balance = 0.0M;
            owner = owner1;
        }

        public BankAccount(string owner2, int account2, decimal balance2)
        {
            account = account2;
            owner = owner2;
            balance = balance2;
        }

        public int GetAccount()
        {
            return account;
        }

        public void SetAccount(int accountNum)
        {
            account = accountNum;
        }

        public string GetOwner()
        {
            return owner;
        }

        public void SetOwner(string accOwner)
        {
            owner = accOwner;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void SetBalance(decimal newBalance)
        {
            balance = newBalance;
        }
    }
}