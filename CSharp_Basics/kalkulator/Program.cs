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
                MathData mathData = UserInterface.GetAllValuesFromCustomer();
                var result = Calculations.Match(mathData);
                Console.WriteLine(result);
            }


        }
       

    } }

