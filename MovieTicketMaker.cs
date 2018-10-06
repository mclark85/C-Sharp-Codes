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
    class MovieTicketMaker
    {
        static void Main(string[] args)
        {
            string show = GetMovie();
            MovieTicket tickets = new MovieTicket(show);
            tickets.FindAge();
            tickets.NumTickets = FindNum(tickets.AgeGroup);
            tickets.CalcCost();
            string crdt = CreditCard();
            tickets.SetCard(crdt);
            tickets.TotalCost();
            WriteLine(tickets.ToString());
            WriteLine();
        }
        public static string GetMovie()
        {
            WriteLine("\nWelcome to the Movie Ticket Purchase Site\n");
            WriteLine("What movie would you like to see\n {0}\n {1}\n {2}\n {3}\n {4}\n", "Chappie", "Unfinished Business", "The SpongeBob Movie", "Kingsman", "Jupiter Ascending");


            string choice = ReadLine();
            return choice;
        }
        public static int FindNum(string A)
        {
            Write("\nHow many {0} tickets do you want? ", A);
            int num = int.Parse(ReadLine());
            return num;
        }
        public static string CreditCard()
        {
            Write("\nWill you use a credit card? ");
            string answer = ReadLine();
            return answer;
        }
    }
}
