using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static bool quit = false;
        static void Main(string[] args)
        {
            while (!quit)
            {
                MathData mathData = new MathData();
                mathData.FirstNumber = UserInterface.GetValueFromUser("Podaj pierwszą liczbę");
                mathData.SecondNumber = UserInterface.GetValueFromUser("Podaj drugą liczbę");
                mathData.Operation = UserInterface.GetOperationFromUser("Podaj działanie");
                var character = Calculations.Match(mathData);

                double result = 0;

                Console.WriteLine(result);
            }


        }
       

    } }

