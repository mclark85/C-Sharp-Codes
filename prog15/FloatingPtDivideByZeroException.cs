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

namespace MClark_Prog15
{
    class FloatingPtDivideByZeroException : System.ApplicationException
    {
        public FloatingPtDivideByZeroException(string exceptionMsg) : base(exceptionMsg)
        {

        }
    }
}
