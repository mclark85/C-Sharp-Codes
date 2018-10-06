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
using static System.Console;

namespace MClark_Prog10
{
    class PlayGame
    {
        static void Main(string[] args)
        {
            string winner = "";
            string name = "";
            int num2 = 0;
            bool player = true;
            bool compU = false;
            bool repeat = false;

            RockPaperPlayer comp = new RockPaperPlayer("Watson");
            Greeting();
            name = GetName();
            RockPaperPlayer user = new RockPaperPlayer(name);
            do
            {
                for (int i = 1; i <= 7; i++)
                {
                    int number = GetNum(player);
                    user.MakeChoice(number);
                    num2 = GetNum(compU);
                    comp.MakeChoice(num2);

                    winner = PlayRound(user, comp);
                    Winner(user, comp, i, winner);

                }
                repeat = RepeatGame();
                user.Wins = 0;
                comp.Wins = 0;
            } while (repeat == true);

        }

        public static void Greeting()
        {
            WriteLine();
            WriteLine("Welcome to the Rock, Paper, Scissors CampionShip!");
            WriteLine();
            WriteLine("You will be playing against the crazy space station computer named HAL.");
            WriteLine("You will need to select a number 1-3 where \n1=Rock \n2=Paper \n3=Scissors");
            WriteLine("The computer will then select a number from 1 to 3 representing the same.");
            WriteLine("The number from the Player and Computer will then be compaired to determine the winner.");
            WriteLine("Seven (7) rounds will be played and the player with the most wins will become the winner. \nReady? Good Luck!");
        }

        public static string GetName()
        {
            Write("\nWhat is your name?  ");
            string userName = ReadLine();
            return userName;
        }

        public static int GetNum(bool player)
        {
            int num = 0;
            if (player == true)
            {
                WriteLine();
                Write("Enter a number 1 - 3:  ");
                num = int.Parse(ReadLine());
                WriteLine();

                while (num < 1 || num > 3)
                {
                    Write("That's not a valid choice. Enter a number 1, 2, or 3: ");
                    num = int.Parse(ReadLine());
                }
            }
            else
            {
                Random comp = new Random();
                num = comp.Next(1, 4);
            }
            return num;
        }
        public static string PlayRound(RockPaperPlayer user, RockPaperPlayer Watson)
        {
            string winner = "";
            string player = user.Choice;
            string comp = Watson.Choice;

            if (player == "rock" && comp == "rock")
            {
                winner = "Round was a Tie\n";
            }
            else if (player == "paper" && comp == "paper")
            {
                winner = "Round was a Tie\n";
            }
            else if (player == "scissors" && comp == "scissors")
            {
                winner = "Round was a Tie\n";
            }

            else if (player == "rock" && comp == "scissors")
            {
                winner = "Winner is: " + user.Name;
                user.Wins += 1;
            }
            else if (player == "paper" && comp == "rock")
            {
                winner = "Winner is: " + user.Name;
                user.Wins += 1;
            }
            else if (player == "scissors" && comp == "paper")
            {
                winner = "Winner is: " + user.Name;
                user.Wins += 1;
            }

            else if (player == "paper" && comp == "scissors")
            {
                winner = "Winner is: " + Watson.Name;
                Watson.Wins += 1;
            }
            else if (player == "scissors" && comp == "rock")
            {
                winner = "Winner is: " + Watson.Name;
                Watson.Wins += 1;
            }
            else if (player == "rock" && comp == "paper")
            {
                winner = "Winner is: " + Watson.Name;
                Watson.Wins += 1;
            }
            return winner;
        }

        public static void Winner(RockPaperPlayer user, RockPaperPlayer Watson, int round, string winner)
        {
            WriteLine("Round " + round);
            WriteLine(user.Name + " chose " + user.Choice);
            WriteLine(Watson.Name + " chose " + Watson.Choice);
            WriteLine();
            WriteLine(winner);
            WriteLine(user);
            WriteLine(Watson);
            WriteLine();

            if (round == 7)
            {
                if (user.Wins > Watson.Wins)
                {
                    WriteLine("Winner of the game is: " + user.Name);
                }
                else if (user.Wins < Watson.Wins)
                {
                    WriteLine("Winner of the game is: " + Watson.Name);
                }
                else
                {
                    WriteLine("Game was a Tie");
                }
            }
        }

        public static bool RepeatGame()
        {
            WriteLine();
            Write("Would you like to play again?  ");
            string response = ReadLine();

            bool repeat = false;

            if (response == "Yes" || response == "yes")
            {
                repeat = true;
            }
            return repeat;
        }
    }


}