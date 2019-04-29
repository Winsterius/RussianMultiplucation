using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RussMult
{
    public class UI
    {

        public void ShowTitle()
        {
            Console.WriteLine("          ------------------------------------");
            Console.WriteLine("          |                                  |");
            Console.WriteLine("          |     Russische Multiplikation     |");
            Console.WriteLine("          |                                  |");
            Console.WriteLine("          ------------------------------------");
        }

        public void ShowUI(int i, string s, int i2, int i3)
        {

            Console.WriteLine("    -----------------------------------------------------");
            Console.WriteLine("    |               |               | |                 |");
            Console.WriteLine("    |{0,11}    |{1,7}{2,-8}| | {3,13:N0}   |", i, s, i2, i3);
            Console.WriteLine("    |               |               | |                 |");
            Console.WriteLine("    -----------------------------------------------------");

        }

        public void ShowResult(int i, int i2, int i3)
        {
            Console.WriteLine("    -----------------------------------------------------");
            Console.WriteLine("    |               |               | |                 |");
            Console.WriteLine("    |{0,11}    |{1,13}  | |    ={2,9:N0}   |", i, i2, i3);
            Console.WriteLine("    |               |               | |                 |");
            Console.WriteLine("    -----------------------------------------------------");
        }

    }
}