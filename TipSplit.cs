/*Matt Clark
 * Program 4 Due: February 6, 2018
 * None
 * This program will accept user input for the number of people and the bill of eating out and then calculate the total with different tip amounts and how much it is if split evenly.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MClark_Prog4
{
    class TipSplit
    {
        static void Main(string[] args)
        {
            const double TIP_15 = 0.15;
            const double TIP_20 = 0.20;
            decimal tip15Calc;
            decimal tip20Calc;
            decimal tip15Tot;
            decimal tip20Tot;
            decimal tip15Share;
            decimal tip20Share;

            Greeting();
            decimal billTot = GetTotal();
            int numGuests = GetPeople();
            CalcTip(TIP_15, TIP_20, billTot, out tip15Calc, out tip20Calc);
            CalcTotal(billTot, tip15Calc, tip20Calc, out tip15Tot, out tip20Tot);
            SplitBill(numGuests, tip15Tot, tip20Tot, out tip15Share, out tip20Share);
            PrintReceipt(tip15Calc, tip20Calc, tip15Tot, tip20Tot, tip15Share, tip20Share);
        }


        public static void Greeting()
        {
            WriteLine("Welcome to Tiny's Pub Tip Calculator.");
            WriteLine();
        }

        public static decimal GetTotal()
        {
            Write("Enter the bill total:  ");
            decimal bill = decimal.Parse(ReadLine());
            return bill;
        }

        public static void CalcTip(double lowTip, double highTip, decimal bill, out decimal lowTipCalc, out decimal highTipCalc)
        {
            lowTipCalc = bill * (decimal)lowTip;
            highTipCalc = bill * (decimal)highTip;

        }

        public static void CalcTotal(decimal bill, decimal lowTipCalc, decimal highTipCalc, out decimal lowTipTot, out decimal highTipTot)
        {
            lowTipTot = bill + lowTipCalc;
            highTipTot = bill + highTipCalc;
        }

        public static int GetPeople()
        {
            Write("How many people in your party:  ");
            int guests = int.Parse(ReadLine());
            WriteLine();
            return guests;
        }

        public static void SplitBill(int guests, decimal lowTipTot, decimal highTipTot, out decimal lowShare, out decimal highShare)
        {
            lowShare = lowTipTot / guests;
            highShare = highTipTot / guests;
        }

        public static void PrintReceipt(decimal lowTipCalc, decimal highTipCalc, decimal lowTipTot, decimal highTipTot, decimal lowShare, decimal highShare)
        {
            WriteLine("15% tip would be: {0, 21:C}", lowTipCalc);
            WriteLine("20% tip would be: {0, 21:C}", highTipCalc);
            WriteLine("");

            WriteLine("Total for 15% tip would be: {0, 11:C}", lowTipTot);
            WriteLine("Each person's share is: {0, 15:C}", lowShare);
            WriteLine("");

            WriteLine("Total for 20% tip would be: {0, 11:C}", highTipTot);
            WriteLine("Each person's share is: {0, 15:C}", highShare);
        }
    }
}
