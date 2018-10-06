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
    class CellPhoneAccount
    {
        private string plan;
        private bool android;
        private int account;
        private string owner;
        private decimal cost;
        private string phoneType;


        public bool Android
        {
            get
            {
                return android;
            }
            set
            {
                android = value;
            }
        }

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
            set
            {
                account = value;
            }
        }

        public CellPhoneAccount(int acct, string user, string phone)
        {
            plan = "";
            cost = 0;
            Account = acct;
            Owner = user;
            phoneType = phone;

            if (phoneType == "Samsung" || phoneType == "LG" || phoneType == "HTC" || phoneType == "Motorola")
            {
                Android = true;
            }
            else
            {
                Android = false;
            }
        }

        public void SetPhonePlanAndCost(char pt)
        {
            switch (pt)
            {
                case 'A':
                    plan = "Hermit";
                    cost = 10;
                    break;
                case 'B':
                    plan = "Anti-Social";
                    cost = 40;
                    break;
                case 'C':
                    plan = "Granny";
                    cost = 60;
                    break;
                case 'D':
                    plan = "Socialite";
                    cost = 99;
                    break;
            }
        }

        public override string ToString()
        {
            string droid = "";
            if (android == true)
            {
                droid = "is";
            }
            else
            {
                droid = "is not";
            }
            return "\nName:  " + owner + "\nAccount:  " + account + "\nPlan:  " + plan + "\nCost:  " + cost.ToString("C") + "\nPhone:  " + phoneType + "\nThis phone " + droid + " an Android.\n";

        }
    }
}
