/* Matt Clark
 * Program 12 Due: April 10, 2018
 * None
 * This program will accept information about 4 students and will then search for and find similar information the user submits.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MClark_Prog12
{
    class IWCCGraduation
    {
        static void Main(string[] args)
        {
            int id = 0;
            double gpa = 0.0;
            int choice = 0;
            string lname = "";
            string fname = "";
            string major = "";



            Greeting();
            IWCCStudent[] students = new IWCCStudent[4];
            for (int i = 0; i < students.Length; i++)
            {
                GetInfo(out lname, out fname, out major);
                id = GetId();
                gpa = GetGpa();
                students[i] = new IWCCStudent(lname, fname, major, id, gpa);
            }
            do
            {
                DisplayMenu();
                choice = GetChoice();
                DoChoice(students, choice);
            } while (choice != 4);
        }


        public static void Greeting()
        {
            WriteLine("IWCC Students Input");
            WriteLine();
        }


        public static void GetInfo(out string lnam, out string fnam, out string majo)
        {
            Write("Enter student's last name:  ");
            lnam = ReadLine();
            Write("Enter student's first name:  ");
            fnam = ReadLine();
            Write("Enter student's major:  ");
            majo = ReadLine();
        }


        public static int GetId()
        {
            int id = 0;

            Write("Enter student's ID number:  ");
            id = int.Parse(ReadLine());

            while (id <= 0)
            {
                WriteLine("Student ID must be greater than 0.");
                Write("Enter student's ID number:  ");
                id = int.Parse(ReadLine());
            }

            return id;
        }


        public static double GetGpa()
        {
            double gpa = 0.0;

            Write("Enter student's GPA:  ");
            gpa = double.Parse(ReadLine());
            WriteLine();

            while (gpa < 0.0 || gpa > 4.0)
            {
                Write("That wasn't a valid grade.  Try again:  ");
                Write("Enter student's GPA:  ");
                gpa = double.Parse(ReadLine());
            }

            return gpa;
        }


        public static void DisplayMenu()
        {
            WriteLine();
            WriteLine("1. Search by Last Name");
            WriteLine("2. Search by First Name");
            WriteLine("3. Search by Major");
            WriteLine("4. Quit");
            WriteLine();
        }


        public static int GetChoice()
        {
            int choice = 0;

            Write("Enter your choice:  ");
            choice = int.Parse(ReadLine());

            while (choice < 1 || choice > 4)
            {
                WriteLine("That was not a valid choice. Enter again.");
                WriteLine();
                DisplayMenu();
                Write("Enter your choice:  ");
                choice = int.Parse(ReadLine());
            }

            return choice;
        }


        public static void DoChoice(IWCCStudent[] students, int choose)
        {
            if (choose == 1)
            {
                FindLastName(students);
            }
            else if (choose == 2)
            {
                FindFirstName(students);
            }
            else if (choose == 3)
            {
                FindMajor(students);
            }

        }


        public static void FindLastName(IWCCStudent[] students)
        {
            string lastn = "";
            int counter = 0;

            Write("What is the last name:  ");
            lastn = ReadLine();
            WriteLine();

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Lname == lastn)
                {
                    PrintStudent(students[i]);
                    counter++;
                }
            }

            if (counter == 0)
            {
                WriteLine("No last name of {0} found.", lastn);
            }
        }


        public static void FindFirstName(IWCCStudent[] students)
        {
            string firstn = "";
            int counter = 0;

            Write("What is the first name:  ");
            firstn = ReadLine();
            WriteLine();

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Fname == firstn)
                {
                    PrintStudent(students[i]);
                    counter++;
                }
            }

            if (counter == 0)
            {
                WriteLine("No first name of {0} found.", firstn);
            }
        }


        public static void FindMajor(IWCCStudent[] students)
        {
            int counter = 0;
            string maj = "";

            Write("What is the major:  ");
            maj = ReadLine();
            WriteLine();

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Major == maj)
                {
                    PrintStudent(students[i]);
                    counter++;
                }
                
            }

            if (counter == 0)
            {
                WriteLine("No major of {0} found.", maj);
            }
        }


        public static void PrintStudent(IWCCStudent stu)
        {
            WriteLine(stu);
        }
    }
}
