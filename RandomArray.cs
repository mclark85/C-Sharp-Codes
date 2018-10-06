/* Matt Clark
 * Program 13 Due: April 17, 2018
 * None
 * This program will fill an array using a random number generator.  It will then find the sum of the array, each row, and column.  Finally, it will ask the user for a number and determine if it is there and what the position is.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MClark_Prog13
{
    class RandomArray
    {
        static void Main(string[] args)
        {
            int row = 0;
            int col = 0;
            int arrayTot = 0;
            int useNum = 0;
            bool numThere = false;
            int[,] ranNums = new int[3, 5];

            FillArray(ranNums);
            PrintArray(ranNums);
            SumRows(ranNums);
            SumCols(ranNums);
            arrayTot = SumArray(ranNums);

            WriteLine();
            WriteLine("Total sum of the array is:  {0}", arrayTot);
            WriteLine();

            useNum = GetNumber();
            numThere = SearchArray(useNum, ranNums, ref row, ref col);

            if (numThere == true)
            {
                WriteLine();
                WriteLine("Your number, {0}, was found at row index {1} and column index {2}.", useNum, row, col);
                WriteLine();
            }
            else
            {
                WriteLine();
                WriteLine("Your number, {0}, was not found.", useNum);
                WriteLine();
            }
        }


        public static void FillArray(int[,] nums)
        {
            Random num = new Random();
            for (int r = 0; r < nums.GetLength(0); r++)
            {
                for (int c = 0; c < nums.GetLength(1); c++)
                {
                    nums[r, c] = num.Next(15, 97);
                }
            }
        }


        public static void PrintArray(int[,] nums)
        {
            int aNum = 0;

            for (int r = 0; r < nums.GetLength(0); r++)
            {
                WriteLine();
                for (int c = 0; c < nums.GetLength(1); c++)
                {
                    aNum = nums[r, c];
                    Write("{0} ", aNum);
                }
            }
            WriteLine();
        }


        public static void SumRows(int[,] nums)
        {
            int rowTot = 0;

            for (int r = 0; r < nums.GetLength(0); r++)
            {
                rowTot = 0;

                WriteLine();
                for (int c = 0; c < nums.GetLength(1); c++)
                {

                    rowTot += nums[r, c];

                }

                Write("The total sum for row {0} is:  {1}", r + 1, rowTot);
            }
            WriteLine();
        }


        public static void SumCols(int[,] nums)
        {
            int colTot = 0;
            int r = 0;

            for (int c = 0; c < nums.GetLength(1); c++)
            {

                WriteLine();

                colTot = 0;

                for (r = 0; r < nums.GetLength(0); r++)
                {

                    colTot += nums[r, c];

                }

                Write("The total sum for column {0} is:  {1}", c + 1, colTot);
            }
            WriteLine();
        }


        public static int SumArray(int[,] nums)
        {
            int tot = 0;

            for (int r = 0; r < nums.GetLength(0); r++)
            {
                for (int c = 0; c < nums.GetLength(1); c++)
                {
                    tot += nums[r, c];
                }
            }

            return tot;
        }


        public static int GetNumber()
        {
            int userNum = 0;

            Write("Please enter a number between 15 and 96:  ");
            userNum = int.Parse(ReadLine());
            while (userNum < 15 || userNum > 96)
            {
                Write("Number was not between 15 and 96.  Try again:  ");
                userNum = int.Parse(ReadLine());
            }
            return userNum;
        }


        public static bool SearchArray(int userNum, int[,] nums, ref int row1, ref int col1)
        {
            bool present = false;

            for (int r = 0; r < nums.GetLength(0); r++)
            {
                for (int c = 0; c < nums.GetLength(1); c++)
                {
                    if (userNum == nums[r, c])
                    {
                        row1 = r;
                        col1 = c;
                        present = true;
                        break;
                    }
                }

                if (present == true)
                {
                    break;
                }
            }

            return present;
        }
    }
}
