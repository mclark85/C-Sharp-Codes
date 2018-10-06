/* Matt Clark
 * Program 1 Due: January 16, 2018
 * None
 * This program will print lines using by using different escape charters and different methods of Write.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MClark_Prog1
{
    class Output
    {
        static void Main(string[] args)
        {
            WriteLine("Output #1");
            Write("\tThose who prepare ");
            Write("in times of peace.  ");
            Write("Bleed less in times of war.\n");
            WriteLine();

            WriteLine("Output #2");
            Write("\tThose who prepare\n");
            Write("\tin times of peace.\n");
            Write("\tBleed less in times of war.\n");
            WriteLine();

            WriteLine("Output #3");
            Write("\tThose\n\twho\n\tprepare\n\tin\n\ttimes\n\tof\n\tpeace.\n\tBleed\n\tless\n\tin\n\ttimes\n\tof\n\twar.\n");
        }
    }
}
