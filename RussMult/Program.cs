using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussMult
{
    class Program
    {
        static void Main(string[] args)
        {
            UI ui = new UI();
            Input input = new Input();
            Calculation calculation = new Calculation();

            ui.ShowTitle();
            calculation.calculation();

        }
    }
}
