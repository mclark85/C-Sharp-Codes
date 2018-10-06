/* Matt Clark
 * Program 14 Due: April 24, 2018
 * None
 * This program will accept the types of pizzas sold each day of the week and will then print them out.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MClark_Prog14
{
    class PizzaReport
    {
        static void Main(string[] args)
        {
            string[][] pizzas = new string[7][];

            Greeting();
            GetPizza(pizzas);
            RunReport(pizzas);
        }


        public static void Greeting()
        {
            WriteLine("This is Mama Jane's weekly Pizza Report\nPlease enter the appropriate information.");
            WriteLine();
        }


        public static void GetPizza(string[][] getPizza)
        {
            int num = 0;
            int day = 0;
            string DOW = "";
            string pizzaType = "";
            string pizzasLower = "";
            string input;

            for (int r = 0; r < getPizza.Length; r++)
            {
                day = r;
                switch (day)
                {
                    case 0:
                        DOW = "Monday";
                        break;
                    case 1:
                        DOW = "Tuesday";
                        break;
                    case 2:
                        DOW = "Wednesday";
                        break;
                    case 3:
                        DOW = "Thursday";
                        break;
                    case 4:
                        DOW = "Friday";
                        break;
                    case 5:
                        DOW = "Saturday";
                        break;
                    default:
                        DOW = "Sunday";
                        break;
                }

                Write("How many pizzas were sold on {0}?  ", DOW);
                num = int.Parse(ReadLine());

                while (num < 0)
                {
                    WriteLine("That is not an acceptable number.  Please try again.");
                    Write("How many pizzas were sold on {0}?  ", DOW);
                    num = int.Parse(ReadLine());
                }
                getPizza[r] = new string[num];

                if (num == 0)
                {
                    continue;
                }

                Write("Enter all the pizza types for {0}, seperated by spaces:  ", DOW);
                pizzaType = ReadLine();
                pizzasLower = pizzaType.ToLower();
                string[] arr = pizzasLower.Split(' ');

                while (num != arr.Length)
                {
                    WriteLine("Input does not match number needed.  Try again.");
                    Write("Enter all the pizza types for {0}, seperated by spaces:  ", DOW);
                    pizzaType = ReadLine();
                    pizzasLower = pizzaType.ToLower();
                    arr = pizzasLower.Split(' ');
                }

                for (int c = 0; c < getPizza[r].Length; c++)
                {
                    input = arr[c];
                    getPizza[r][c] = input;
                }

            }
        }


        public static void RunReport(string[][] runPizza)
        {
            int cheese = 0;
            int pep = 0;
            int haw = 0;
            int sup = 0;
            string pizza = "";

            WriteLine();
            WriteLine("This weeks sales were:");

            for (int r = 0; r < runPizza.Length; r++)
            {
                for (int c = 0; c < runPizza[r].Length; c++)
                {
                    pizza = runPizza[r][c];
                    switch (pizza)
                    {
                        case "cheese":
                            cheese++;
                            break;
                        case "pepperoni":
                            pep++;
                            break;
                        case "hawaiian":
                            haw++;
                            break;
                        case "supreme":
                            sup++;
                            break;
                    }

                }
            }

            WriteLine("{0} cheese pizzas.", cheese);
            WriteLine("{0} pepperoni pizzas.", pep);
            WriteLine("{0} hawaiian pizzas.", haw);
            WriteLine("{0} supreme pizzas.", sup);
            WriteLine();
        }
    }
}
