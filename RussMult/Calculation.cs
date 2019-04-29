using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RussMult
{
    public class Calculation
    {
        Input input = new Input();
        UI ui = new UI();
        int result = 0;
        int firstInt;
        int secondInt;
        bool finish = false;
        int output1, output2;

        public void calculation()
        {           
            output1 = input.AskForNumber("erste");
            output2 = input.AskForNumber("zweite");
            firstInt = output1;
            secondInt = output2;
            if (firstInt % 2 != 2 && firstInt % 2 != 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                result += secondInt;
                ui.ShowUI(firstInt, "+", secondInt, result);
                Console.ResetColor();
            }
            while (!finish)
            {
                if (firstInt == 1)
                {
                    finish = true;
                }
                else if ((firstInt / 2) % 2 == 0)
                {
                    secondInt *= 2;
                    firstInt /= 2;
                    Console.ForegroundColor = ConsoleColor.Red;
                    ui.ShowUI(firstInt, " ", secondInt, result);
                    Console.ResetColor();
                }
                else if ((firstInt / 2) % 2 != 2)
                {
                    secondInt *= 2;
                    firstInt /= 2;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    result += secondInt;
                    ui.ShowUI(firstInt, "+", secondInt, result);
                    Console.ResetColor();
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            ui.ShowResult(output1, output2, result);
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
    }
}