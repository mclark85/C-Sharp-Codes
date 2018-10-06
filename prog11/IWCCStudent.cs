/* Matt Clark
 * Program 11 Due: April 3, 2018
 * None
 * This program will take in information about a students grades and will determine whether or not the student can graduate based on GPA and if all classes were taken and passed.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MClark_Prog11
{
    class IWCCStudent
    {
        static void Main(string[] args)
        {
            string student = "";

            IWCCGraduation grad = new IWCCGraduation();
            student = GetStudentName();
            grad.Name = student;
            WriteLine();
            grad.EnterGrades();
            grad.CalcGPA();
            grad.PrintGrades();
            WriteLine();
            CanGraduate(grad);
        }


        public static string GetStudentName()
        {
            Write("Enter student's name:  ");
            string name = ReadLine();
            return name;
        }


        public static void CanGraduate(IWCCGraduation graduate)
        {
            bool canGrad = false;
            canGrad = graduate.MissingClasses();

            if (canGrad == true)
            {
                WriteLine("{0} may not graduate due to above missing or failed classes.", graduate.Name);
            }
            else if (graduate.GPA < 2.00)
            {
                WriteLine("{0} may not graduate due to insuffucent GPA of {1:F2}.", graduate.Name, graduate.GPA);
            }
            else
            {
                WriteLine("{0} may graduate with a {1:F2} GPA.", graduate.Name, graduate.GPA);
            }
        }
    }
}
