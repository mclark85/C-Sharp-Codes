/*Matt Clark
 *Program 15 Due: May 1, 2018
 *Blaine Smith
 * This program will accept from the user the number of classes taken and the grades for those classes.  It will then return the Gpa of the selected semester and the cumulative gpa.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MClark_Prog15
{
    class StudentGrades
    {
        private char[][] grades;
        private double totalGpa = 0.0;
        private int totalClasses;
        private int semesters;


        public int Semesters
        {
            get
            {
                return semesters;
            }
            set
            {
                semesters = value;
            }
        }


        public double TotalGpa
        {
            get
            {
                return totalGpa;
            }
            set
            {
                totalGpa = value;
            }
        }


        public StudentGrades()
        {
            totalClasses = 0;
            SetSemesters(4);
            grades = new char[semesters][];
        }


        public void SetSemesters(int semest)
        {
            if (semest < 1)
            {
                WriteLine("Error value less than 1, will set to 0");
                semest = 0;
            }
            else
            {
                semesters = semest;
            }
        }


        public void InputSemesters()
        {
            bool flag;
            int semNum = 0;
            for (int r = 0; r < grades.Length; r++)
            {
                do
                {
                    flag = false;
                    try
                    {
                        Write("How many courses were taken semester {0}:  ", r + 1);
                        semNum = int.Parse(ReadLine());
                        CreateSemesters(r, semNum);
                    }
                    catch (System.Exception e)
                    {
                        flag = true;
                        WriteLine("Problem with input");
                        Error.WriteLine(e.Message);
                        WriteLine("Try again.");
                    }
                } while (flag);
            }
            WriteLine("\nAll classes have been entered.");
        }


        public void CreateSemesters(int sem, int numClasses)
        {
            grades[sem] = new char[numClasses];
            totalClasses = numClasses;
        }


        public void EnterGrades()
        {
            for (int r = 0; r < grades.Length; r++)
            {
                for (int c = 0; c < grades[r].Length; c++)
                {
                    bool flag;
                    do
                    {
                        flag = false;
                        try
                        {
                            Write("Enter letter grade for class {0} of semester {1}:  ", c + 1, r + 1);
                            grades[r][c] = char.Parse(ReadLine());
                            CheckLetterGrade(grades[r][c]);
                        }
                        catch (IncorrectLetterGradeException E)
                        {
                            Error.WriteLine(E.Message);
                            flag = true;
                        }
                        catch
                        {
                            WriteLine("Please enter a character.  Try again.\nNot an acceptable letter grade of A-D or F");
                            flag = true;
                        }

                    } while (flag);
                }
            }
        }


        public void CheckLetterGrade(char G)
        {
            bool let = false;
            switch (G)
            {
                case 'A':
                    let = true;
                    break;
                case 'B':
                    let = true;
                    break;
                case 'C':
                    let = true;
                    break;
                case 'D':
                    let = true;
                    break;
                case 'F':
                    let = true;
                    break;
            }
            if (let == false)
            {
                IncorrectLetterGradeException weewoo = new IncorrectLetterGradeException("That is not an acceptable letter grade.  Try again.\nNot an acceptable letter grade of A-D or F");
                throw weewoo;
            }
        }


        public double SemesterGpa(int semest)
        {
            double semGpa = 0;
            double totGpa = 0;
            double semTot = 0.0;
            int count = 0;
            for (int c = 0; c < grades[semest - 1].Length; c++)
            {
                switch (grades[semest - 1][c])
                {
                    case 'A':
                        semGpa = 4.0;
                        break;
                    case 'B':
                        semGpa = 3.0;
                        break;
                    case 'C':
                        semGpa = 2.0;
                        break;
                    case 'D':
                        semGpa = 1.0;
                        break;
                    case 'F':
                        semGpa = 0.0;
                        break;
                }
                count++;
                semTot += semGpa;
            }
            try
            {
                totGpa = CalcGpa(semTot, count);
            }
            catch (FloatingPtDivideByZeroException E)
            {
                Error.WriteLine(E.Message);
                totGpa = 0.0;
            }

            return totGpa;
        }


        public void CumGpa()
        {
            int colCount = 0;
            int rCount = 0;
            double tot = 0.0;
            double semGpa = 0.0;
            double total = 0.0;
            for (int r = 0; r < grades.Length; r++)
            {
                for (int c = 0; c < grades[r].Length; c++)
                {
                    switch (grades[r][c])
                    {
                        case 'A':
                            semGpa = 4.0;
                            break;
                        case 'B':
                            semGpa = 3.0;
                            break;
                        case 'C':
                            semGpa = 2.0;
                            break;
                        case 'D':
                            semGpa = 1.0;
                            break;
                        case 'F':
                            semGpa = 0.0;
                            break;
                    }
                    colCount++;
                    tot += semGpa;
                }
                rCount += colCount;
                total += tot;
            }
            try
            {
                totalGpa = CalcGpa(total, rCount);
            }
            catch (FloatingPtDivideByZeroException E)
            {
                Error.WriteLine(E.Message);
                totalGpa = 0.0;
            }

        }


        public double CalcGpa(double total, int classes)
        {
            if (classes < 1)
            {
                FloatingPtDivideByZeroException zero = new FloatingPtDivideByZeroException("Exception Type: Dividing by zero\nStudent must take a class before semester GPA can be calculated");
                throw zero;
            }
            double sum = total / classes;
            return sum;
        }


        public override string ToString()
        {
            string gString = "";
            int r = 0;
            int c = 0;
            for (r = 0; r < grades.Length; r++)
            {
                gString += "\nSemester " + (r + 1) + ": ";
                for (c = 0; c < grades[r].Length; c++)
                {
                    gString += grades[r][c] + " ";
                }
            }
            return string.Format("Students grades are: {0}", gString);

        }
    }
}
