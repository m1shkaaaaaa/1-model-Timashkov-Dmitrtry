using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_zd_1_model
{
    internal class Program
    {
        static void Main(string[] args)
        {
            name_and_surname.name_and_surname_vivod();
        }
        class name_and_surname
        {
            public static void name_and_surname_vivod()
            {
                string name;
                string surname;

                do
                {
                    Console.WriteLine("Введите своё имя: "); // Запрашиваем ввод имени пользователя
                    name = Console.ReadLine();

                    if (!Regex.IsMatch(name, @"^[а-яА-Я]+$")) // Проверяем введенное имя с помощью регулярного выражения
                    {
                        Console.WriteLine("Вы ввели неправильное имя. Используйте только русские буквы и не ставьте пробел после имя."); // Если имя содержит недопустимые символы, выводим сообщение об ошибке
                        Console.WriteLine("Нажмите Enter для продолжения");
                        Console.ReadLine();
                        Console.Clear(); // Очищаем консоль для повторного ввода
                    }

                } while (!Regex.IsMatch(name, @"^[а-яА-Я]+$"));

                do
                {
                    Console.WriteLine("Введите свою фамилию: "); // Запрашиваем ввод фамилии пользователя
                    surname = Console.ReadLine();

                    if (!Regex.IsMatch(surname, @"^[а-яА-Я]+$")) // Проверяем введенное имя с помощью регулярного выражения
                    {
                        Console.WriteLine("Вы ввели неправильную фамилию. Используйте только русские буквы и не ставьте пробел после фамилии."); // Если фамилия содержит недопустимые символы, выводим сообщение об ошибке
                        Console.WriteLine("Нажмите Enter для продолжения");
                        Console.ReadLine();
                        Console.Clear(); // Очищаем консоль для повторного ввода
                    }

                } while (!Regex.IsMatch(surname, @"^[а-яА-Я]+$"));

                Console.WriteLine($"Привет, {name} {surname}"); // Выводим приветственное сообщение с именем и фамилией пользователя
                Console.ReadLine();
            }
        }
    }
}
