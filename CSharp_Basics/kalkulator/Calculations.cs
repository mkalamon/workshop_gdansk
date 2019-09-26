using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    public static class Calculations
    {


        public static double Match(MathData mathData)
        {
            double result = 0;
            switch (mathData.Operation)
            {
                case "+":
                    result = Add(mathData.FirstNumber, mathData.SecondNumber);
                    break;

                case "-":
                    result = Substract(mathData.FirstNumber, mathData.SecondNumber);
                    break;

                case "*":
                    result = Multiple(mathData.FirstNumber, mathData.SecondNumber);
                    break;

                case "x":
                    result = Multiple(mathData.FirstNumber, mathData.SecondNumber);
                    break;

                case "/":
                    if (mathData.SecondNumber == 0)
                    {
                        Console.WriteLine("Nie można dzielić przez 0");
                        break;
                    }
                    result = Divide(mathData.FirstNumber, mathData.SecondNumber);
                    break;

                default:
                    Console.WriteLine("Nieznany symbol");
                    break;

            }
            return result;
        }

        private static int Add(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }
        private static int Substract(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            return result;
        }
        private static int Multiple(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            return result;
        }
        private static double Divide(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            return result;
        }
    }
}
