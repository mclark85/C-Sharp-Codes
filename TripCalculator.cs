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

namespace MClark_Prog6
{
    class TripCalculator
    {
        private string destination;
        private double distance;
        private decimal costGas;
        private double mpg;

        public decimal CostGas
        {
            get
            {
                return costGas;
            }
            set
            {
                costGas = value;
            }
        }

        public string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }

        public TripCalculator()
        {
            destination = "";
            distance = 0;
            costGas = 0.0M;
            mpg = 0;
        }

        public TripCalculator(string dest, decimal CG)
        {
            destination = dest;
            distance = 0;
            costGas = CG;
            mpg = 0;
        }

        public void SetDistance(double miles)
        {
            distance = miles;
        }

        public void SetMpg(double gas)
        {
            mpg = gas;
        }

        public double GetDistance()
        {
            return distance;
        }

        public double GetMpg()
        {
            return mpg;
        }

        public double GalsUsed()
        {
            double used = distance / mpg;
            return used;
        }

        public decimal CostPerMile()
        {
            decimal cost = TotalCost();
            decimal milesCost = cost / (decimal)distance;
            return milesCost;
        }

        public decimal TotalCost()
        {
            double used = GalsUsed();
            decimal cost = (decimal)used * costGas;
            return cost;
        }

        public override string ToString()
        {
            return string.Format("Destination:  {0}\nTotal Miles:  {1}\nMiles per Gallon:  {2}\nCost of Gas:  {3}\n", destination, distance, mpg, costGas);
        }
    }

}
