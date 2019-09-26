using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Podaj pierwszą liczbę");
            string number1 = Console.ReadLine();
            int numberOne = int.Parse(number1);

            Console.WriteLine("Podaj drugą liczbę");
            string number2 = Console.ReadLine();
            int numberTwo = int.Parse(number2);

            int add = numberOne + numberTwo;

            Console.WriteLine($"Wynik: {add}");


            //Console.ReadLine();
            Console.ReadKey();
        }
    }
}
