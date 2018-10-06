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
    class UseStudentGrades
    {
        static void Main(string[] args)
        {
            StudentGrades stu = new StudentGrades();
            stu.InputSemesters();
            WriteLine();
            stu.EnterGrades();
            stu.CumGpa();
            WriteLine();
            WriteLine("{0}", stu);
            WriteLine();
            SingleSemesterGpa(stu);
            WriteLine();
            WriteLine("{0}", stu);
            WriteLine();
            WriteLine("Total GPA is:  {0:F2}.", stu.TotalGpa);
        }


        public static void SingleSemesterGpa(StudentGrades stu)
        {
            string ans = "";
            double things = 0;
            do
            {
                Write("For what semester would you like a GPA for?  ");
                int num;
                bool useNum = int.TryParse(ReadLine(), out num);

                while (num < 1 || num > 4)
                {
                    WriteLine("Number needs to be between 1 and {0}", stu.Semesters);
                    Write("For what semester would you like a GPA for?  ");
                    useNum = int.TryParse(ReadLine(), out num);
                };
                things = stu.SemesterGpa(num);
                WriteLine("The GPA for semester {0} is {1:F2}", num, things);
                Write("Would you like another semester GPA?  ");
                ans = ReadLine();
            } while (ans.ToLower() == "yes");
        }
    }
}
