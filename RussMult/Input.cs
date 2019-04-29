using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RussMult
{
    public class Input
    {
        int result;

        public int AskForNumber(string s)
        {
            Console.WriteLine("             Geben Sie die {0} Zahl ein", s);
            while (!int.TryParse(Console.ReadLine(), out int result))
            {                               
                 Console.WriteLine("           Falsche Eingabe!");                                             
            }            
            return result;
        }
    }
}