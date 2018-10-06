/*Matt Clark
* Program 7 Due: Feb. 27, 2018
* None
* This program will accept a user's choice concerning the movie they want to watch, how many tickets of what type the want and will then print out the information including the price to see the movie.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MClark_Prog7
{
    class MovieTicket
    {
        private string movie;
        private string ageGroup;
        private int numTickets;
        private decimal cost;
        private decimal totalCost;
        private bool card;

        public string AgeGroup
        {
            get
            {
                return ageGroup;
            }

            set
            {
                ageGroup = value;
            }
        }

        public int NumTickets
        {
            get
            {
                return numTickets;
            }

            set
            {
                numTickets = value;
            }
        }

        public MovieTicket(string M)
        {
            movie = M;
            ageGroup = "";
            numTickets = 0;
            cost = 0;
            totalCost = 0;
            card = false;
        }

        public void SetCard(string credit)
        {
            if (credit == "yes" || credit == "Yes")
            {
                card = true;
            }
            else
            {
                card = false;
            }
        }

        public void FindAge()
        {
            WriteLine("\n\nTicket prices are:  ");
            WriteLine("Child <under 12> - $5.00");
            WriteLine("Student <with ID> or Educator - $7.00");
            WriteLine("Adult - $12.00");
            WriteLine("Senior or Venteran - $4.00");
            WriteLine();
            Write("What age group are you purchasing?  ");
            ageGroup = ReadLine();

        }

        public void CalcCost()
        {
            if (ageGroup == "Child")
            {
                cost = 5.00M;
            }
            else if (ageGroup == "Student" || ageGroup == "Educator")
            {
                cost = 7.00M;
            }
            else if (ageGroup == "Adult")
            {
                cost = 12.00M;
            }
            else
            {
                cost = 4.00M;
            }
        }

        public void TotalCost()
        {
            totalCost = cost * numTickets;
        }

        public override string ToString()
        {
            string discount = "";

            if (card == true)
            {
                discount = "\nBe sure to bring your credit card.";
            }
            else
            {
                discount = "\nYou will recieve a 10% discount for cash.";
            }

            string result = "\n" + numTickets + " tickets for " + movie + " at " + cost.ToString("c") + " is " + totalCost.ToString("c") + discount;
            return result;
        }


    }

}
