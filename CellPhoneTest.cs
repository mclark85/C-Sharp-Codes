/*Matt Clark
 *Program 8 Due: March 6, 2018
 * None
 * This program will ask users for information pertaining to a cell phone plan and will then display information based on their inputs.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MClark_Prog8Start
{
    class CellPhoneTest
    {
        static void Main(string[] args)
        {
            int accountNum;
            string ownerName;
            string phoneBrand = "";
            char planChoice;

            Greeting();
            GetOwnerAcct(out ownerName, out accountNum);
            phoneBrand = GetPhoneType();
            DisplayMenu();
            planChoice = GetPlanType();

            CellPhoneAccount cellAcc = new CellPhoneAccount(accountNum, ownerName, phoneBrand);
            cellAcc.SetPhonePlanAndCost(planChoice);
            cellAcc.Owner = ownerName;
            cellAcc.Account = accountNum;
            WriteLine(cellAcc.ToString());
        }

        public static void Greeting()
        {
            WriteLine("Hi there and welcome to Merica Mobile!!");
            WriteLine();
        }

        public static void GetOwnerAcct(out string name, out int account)
        {
            Write("Please enter the user's name:  ");
            name = ReadLine();
            Write("Pleane enter the account number:  ");
            int accNum;
            bool goodNum = int.TryParse(ReadLine(), out accNum);

            if (goodNum == false)
            {
                WriteLine("Account number is invalid. Using 999999.");
                account = 999999;
            }
            else
            {
                account = accNum;
            }
        }

        public static string GetPhoneType()
        {
            Write("What is the brand of phone?  ");
            string brand = ReadLine();
            return brand;
        }

        public static void DisplayMenu()
        {
            WriteLine();
            WriteLine("The plans that are available are:");
            WriteLine("A. Hermit Plan - 0GB Data, 0 Texting, 15 minutes Talk, Cost $10");
            WriteLine("B. Anti-Social Plan - 1GB Data, 0 Texting, 60 minutes Talk, Cost $40");
            WriteLine("C. Granny Plan - 2GB Data, Unlimited Text, 120 minutes Talk, Cost $60");
            WriteLine("D. Socialite Plan - 20GB Data, Unlimited Text, Unlimited Talk, Cost $99");
            WriteLine();
        }

        public static char GetPlanType()
        {
            Write("Enter the letter for the plan type you would like:  ");
            char plan;
            bool success = char.TryParse(ReadLine(), out plan);

            if (plan != 'A' && plan != 'B' && plan != 'C' && plan != 'D')
            {
                WriteLine("Unable to determine plan chosen, using plan A, the Hermit Plan.");
                plan = 'A';
            }

            return plan;
        }
    }
}
