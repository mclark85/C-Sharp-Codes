/*Matt Clark
 * Program 6 Due: February 2, 2018
 * None
 * The user will enter in information about a trip and the program will figure out various information inculing overall cost of the trip and cost per mile.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MClark_Prog6
{
    class TripCalculatorTest
    {
        public static void Main(string[] args)
        {
            WriteLine("\nWelcome to the Trip Cost Calculator\n");
            TripCalculator tripOne = new TripCalculator();
            Write("Where are you going? ");
            string place = Console.ReadLine();
            tripOne.Destination = place;
            Write("How many miles is that? ");
            int miles = int.Parse(ReadLine());
            tripOne.SetDistance(miles);
            Write("How many miles per gallon: ");
            double perGallon = double.Parse(ReadLine());
            tripOne.SetMpg(perGallon);
            Write("Cost of gas: ");
            decimal price = decimal.Parse(ReadLine());
            tripOne.CostGas = price;
            WriteLine("\nTrip 1:\n\n{0}", tripOne);

            double gasUsed = tripOne.GalsUsed();
            WriteLine("Total Gallons Used: {0:f2}", gasUsed);
            decimal mileCost = tripOne.CostPerMile();
            WriteLine("Cost per Mile: {0:C}", mileCost);
            decimal costTot = tripOne.TotalCost();
            WriteLine("Total Trip Cost: {0:C}\n\n", costTot);
            TripCalculator tripTwo = new TripCalculator("Kansas City", 2.19M);
            string city = tripTwo.Destination;
            Write("How many miles to " + city + "? ");
            miles = int.Parse(ReadLine());
            tripTwo.SetDistance(miles);
            Write("How many miles per gallon: ");
            perGallon = double.Parse(ReadLine());
            tripTwo.SetMpg(perGallon);
            WriteLine("\n\nTrip 2:\n\n{0}", tripTwo);

            gasUsed = tripTwo.GalsUsed();
            WriteLine("Total Gallons Used: {0:f2}", gasUsed);
            mileCost = tripTwo.CostPerMile();
            WriteLine("Cost per Mile: {0:C}", mileCost);
            costTot = tripTwo.TotalCost();
            WriteLine("Total Trip Cost: {0:C}\n", costTot);
            WriteLine();
        }
    }
}