/*Matt Clark
 * Program 2 Due: January 23, 2018
 * None
 * This will program will calculate information about a Gronala Bar sale including total made, total profits, percentage to give away and amounts sold.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MClark_Prog2
{
    class GranolaSales
    {
        static void Main(string[] args)
        {
            const int CASES_SOLD = 32;
            const double GOV_PERCENT = 0.1275;
            decimal costPerCase = 110m;
            decimal costPerBar = 1.50m;
            int numBarsPerCase = 100;
            decimal totCost = costPerCase * CASES_SOLD;
            int totBars = CASES_SOLD * numBarsPerCase;
            decimal grossIncome = costPerBar * totBars;
            decimal netIncome = grossIncome - totCost;
            decimal govCut = netIncome * (decimal) GOV_PERCENT;
            decimal finalProfit = netIncome - govCut;


            WriteLine("Welcome to the IWCC Nerd Squad Granola Sales Project Final Report");
            WriteLine();
            WriteLine("Number of cases of granola sold: {0, 37:F0}", CASES_SOLD );
            WriteLine("Cost per case: {0, 55:C}", costPerCase );
            WriteLine("Total cost incurred: {0, 49:C}", totCost );
            WriteLine("Number of bars in each case: {0, 41:F0}", numBarsPerCase );
            WriteLine("Total number of bars were sold: {0, 38:F0}", totBars );
            WriteLine("Cost per bar: {0, 56:C}", costPerBar );
            WriteLine("Gross income:{0, 57:C}", grossIncome );
            WriteLine("Net income <Gross income - Total cost incurred>:{0, 22:C}", netIncome );
            WriteLine("Percent to be given to student government: {0, 27:P}", GOV_PERCENT );
            WriteLine("Amount of net income to be given to student government: {0, 14:C}", govCut );
            WriteLine();
            WriteLine("Final Profit for the Nerd Squad: {0, 37:C}", finalProfit );

        }
    }
}
