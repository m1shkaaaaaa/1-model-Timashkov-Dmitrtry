using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Timashkov_Dmitry
{
    class vivod
    {
        static void Main(string[] args)
        {
            even_or_odd.even_or_odd_vivod();
        }
    }
}


class even_or_odd
{
    public static void even_or_odd_vivod()
    {
        double number; // Объявляем переменную для хранения введенного числа
        bool isNumber; // Флаг, указывающий, является ли введенное значение числом

        do
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Введите число: "); // Просим пользователя ввести число
            string input = Console.ReadLine(); // Считываем введенную строку
            isNumber = Double.TryParse(input, out number); // Пытаемся преобразовать введенную строку в число

            if (!isNumber)
            {
                Console.WriteLine("Вы ввели не число. Необходимо ввести число.");
                Console.WriteLine("Нажмите Enter для продолжения");
                Console.ReadLine();
                Console.Clear(); // Если введено не число, выводим сообщение об ошибке и очищаем консоль
            }
        }
        while (!isNumber); // Повторяем цикл, пока не будет введено корректное число

        if (number % 2 == 0)
        {
            Console.WriteLine($"Число {number} чётное"); // Если число четное, выводим сообщение
        }
        else
        {
            Console.WriteLine($"Число {number} нечётное"); // Если число нечетное, выводим сообщение
        }
    }
}