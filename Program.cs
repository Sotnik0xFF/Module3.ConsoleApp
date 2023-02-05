using System;
using System.Text;

namespace Module3.ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            int age;
            bool isParsed;
            do
            {
                Console.Write("Введите ваш возраст: ");

                isParsed = int.TryParse(Console.ReadLine(), out age);
                if (!isParsed)
                {
                    Console.WriteLine("Ошибка ввода! Нажмите любую клавишу и попробуйте еще раз...");
                    Console.ReadKey(true);
                }
            } while (!isParsed);

            Console.WriteLine($"Ваше имя {name} и возраст {age}.");

            Console.Write("Введите вашу дату рождения: ");
            string birthdate = Console.ReadLine();
            Console.WriteLine("Ваша дата рождения " + birthdate);
            Console.ReadKey();
        }
    }
}
