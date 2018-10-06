/* Matt Clark
 * Prog 10 Due: March 27, 2018
 * Blaine Smith
 * This program will have a user play rock, paper, scissors against a computer.
 * The program will determine the winner, keep track of the score and print out the results.
 * It will determine the overall winner of a 7 round game and will ask if the user wants to play again.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MClark_Prog10
{
    class RockPaperPlayer
    {
        private string name;
        private int wins;
        private string choice;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Choice
        {
            get
            {
                return choice;
            }
            set
            {
                choice = value;
            }
        }

        public int Wins
        {
            get
            {
                return wins;
            }
            set
            {
                wins = value;
            }
        }

        public RockPaperPlayer(string nam)
        {
            name = nam;
            wins = 0;
        }

        public void MakeChoice(int num)
        {
            switch (num)
            {
                case 1:
                    choice = "rock";
                    break;
                case 2:
                    choice = "paper";
                    break;
                case 3:
                    choice = "scissors";
                    break;
            }
        }

        public override string ToString()
        {
            return string.Format("Name:  {0}\nWins:  {1}", name, wins);
        }
    }
}
