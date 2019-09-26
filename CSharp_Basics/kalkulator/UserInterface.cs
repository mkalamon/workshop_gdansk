using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class UserInterface
    {
        public static MathData GetAllValuesFromCustomer()
        {
            int first = GetValueFromUser("Podaj pierwszą liczbę");
            int second = GetValueFromUser("Podaj drugą liczbę");
            string operation = GetOperationFromUser("Podaj działanie");

            return new MathData(first, second, operation);
        }
        public static int GetValueFromUser(string message)
        {
            bool parsed = false;
            int parsedNumber = 0;

            while (!parsed)
            {
                Console.WriteLine(message);
                string valueFromUser = Console.ReadLine();
                if (IsQuit(valueFromUser))
                {
                    Console.WriteLine("Zamykam aplikację");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                parsed = int.TryParse(valueFromUser, out parsedNumber);
                if (!parsed)
                {
                    message = $"Wartość {valueFromUser} nie jest liczbą, podaj nową";
                }

            }

            return parsedNumber;
        }

        public static string GetOperationFromUser(string message)
        {
            Console.WriteLine(message);
            string operation = Console.ReadLine();
            if (IsQuit(operation))
            {
                Console.WriteLine("Zamykam aplikację");
                Console.ReadKey();
                Environment.Exit(0);
            }
            return operation;
        }

        private static bool IsQuit(string entry)
        {

            return entry == "q";

        }
    }
        
}
