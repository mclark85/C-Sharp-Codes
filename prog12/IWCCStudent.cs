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

namespace MClark_Prog12
{
    class IWCCStudent
    {
        private string lname;
        private string fname;
        private double gpa;
        private string major;
        private int id;

        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }


        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }


        public string Major
        {
            get
            {
                return major;
            }
            set
            {
                major = value;
            }
        }


        public IWCCStudent(string ln, string fn, string maj, int ident, double grade)
        {
            lname = ln;
            fname = fn;
            major = maj;
            gpa = grade;
            id = ident;

        }


        public override string ToString()
        {
            return string.Format("{0}, {1}; {2} {3} {4:F2}", lname, fname, id, major, gpa);
        }
    }
}
