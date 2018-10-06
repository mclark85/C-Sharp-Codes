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
using static System.Console;

namespace MClark_Prog5
{
    class BankAccountTest
    {
        static void Main(string[] args)
        {
            WriteLine("\nWelcome to the Bank Account Program");
            Write("\nWhat is the customer's name:  ");
            string name = ReadLine();
            BankAccount bAccount1 = new BankAccount(name, 12345);

            Write("What is the balance?  ");
            decimal amount = decimal.Parse(ReadLine());
            bAccount1.SetBalance(amount);

            Write("\nWhat is the next customer's name:  ");
            name = ReadLine();


            Write("What is the balance?  ");
            amount = decimal.Parse(ReadLine());

            BankAccount bAccount2 = new BankAccount(name, 12346, amount);


            WriteLine("\n\nAccount 1:");
            WriteLine("Account Number:  {0}", bAccount1.GetAccount());
            WriteLine("Account Owner:  {0}", bAccount1.GetOwner());
            WriteLine("Account Balance:  {0:C}", bAccount1.GetBalance());
            WriteLine("\n\nAccount 2:");
            WriteLine("Account Number:  {0}", bAccount2.GetAccount());
            WriteLine("Account Owner:  {0}", bAccount2.GetOwner());
            WriteLine("Account Balance:  {0:C}", bAccount2.GetBalance());

            WriteLine();

        }
    }
}