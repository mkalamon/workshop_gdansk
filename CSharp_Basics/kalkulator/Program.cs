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

            Console.WriteLine("Podaj działanie");
            string operation = Console.ReadLine();

            double result = 0;

            switch(operation)
            {
                case "+":
                    result = Add(numberOne, numberTwo);
                    break;

                case "-":
                    result = Substract(numberOne, numberTwo);
                    break;

                case "*":
                    result = Multiple(numberOne, numberTwo);
                    break;

                case "/":
                    result = Divide(numberOne, numberTwo);
                    break;

                default:
                    Console.WriteLine("Nieznany symbol");
                    break;

            }
            Console.WriteLine(result);

            //if (operation == "+")
            //{
            //    result = Add(numberOne, numberTwo);
            //}

            //else if (operation == "-")
            //{
            //    result = Substract(numberOne, numberTwo);
            //}       

            //else if (operation == "*")
            //{
            //    result = Multiple(numberOne, numberTwo);
            //}

            //else if (operation == "/")
            //{
            //    result = Divide(numberOne, numberTwo);
            //}

            //else
            //{
            //    Console.WriteLine("Podano zły znak");
            //}



            int add = Add(numberOne, numberTwo);
            int substract = Substract(numberOne, numberTwo);
            int multiple = Multiple(numberOne, numberTwo);
            double divide = Divide(numberOne, numberTwo);

            Console.WriteLine($"Wynik dodawania: {add}");
            Console.WriteLine($"Wynik odejmowania: {substract}");
            Console.WriteLine($"Wynik mnożenia: {multiple}");
            Console.WriteLine($"Wynik dzielenia: {divide}");


            //Console.ReadLine();
            Console.ReadKey();
        }

        public static int Add(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }
        public static int Substract(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            return result;
        }
        public static int Multiple(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            return result;
        }
        public static double Divide(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            return result;
        }
    }
}
