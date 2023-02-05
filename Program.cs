using System;
using System.Text;
using System.Globalization;

namespace Module3.ConsoleApp
{
    internal class Program
    {
        private const string DateFormat = "dd.MM.yyyy";
        private const string ExDateFormat = "dd, MMMM, yyyy   ddd";

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.InputEncoding = Encoding.Unicode;

            string name = GetName();
            int age = GetAge();
            WriteMessage($"Ваше имя {name} и возраст {age}.");

            DateTime birthdate = GetBirthdate();
            WriteMessage(string.Format("Ваша дата рождения: {0}", birthdate.ToString(ExDateFormat)));
            Console.ReadKey();
        }

        static string GetName()
        {
            Console.Write("Введите имя: ");
            return Console.ReadLine();
        }

        static int GetAge()
        {
            int age;
            bool isValid;
            do
            {
                Console.Write("Введите ваш возраст: ");
                isValid = int.TryParse(Console.ReadLine(), out age) && age >= 0;

                if (!isValid)
                {
                    Console.WriteLine("Неверно указан возраст! Нажмите любую клавишу и попробуйте еще раз...");
                    Console.ReadKey(true);
                }
            } while (!isValid);
            return age;
        }

        static DateTime GetBirthdate()
        {
            DateTime result;
            bool isValid;
            do
            {
                Console.Write($"Введите вашу дату рождения ( {DateFormat} ): ");
                isValid = DateTime.TryParseExact(Console.ReadLine(), DateFormat, null, DateTimeStyles.None, out result);
                if (!isValid)
                {
                    Console.WriteLine("Неверно указана дата рождения! Нажмите любую клавишу и попробуйте еще раз...");
                    Console.ReadKey(true);
                }
            } while (!isValid);
            return result;
        }

        static void WriteMessage(string message)
        {
            Console.WriteLine("\n********************");
            Console.WriteLine(message);
            Console.WriteLine("********************\n\n");
        }
    }
}
