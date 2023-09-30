using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zd_1_model
{
    internal class Program
    {
        static void Main(string[] args)
        {
            area_of_the_circle.area_of_the_circle_vivod();
        }
        class area_of_the_circle
        {
            public static void area_of_the_circle_vivod()
            {
                double radius; // Объявляем переменную для хранения введенного числа
                bool isNumber; // Флаг, указывающий, является ли введенное значение числом

                do
                {
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Введите радиус круга: "); // Просим пользователя ввести число
                    string input = Console.ReadLine(); // Считываем введенную строку
                    isNumber = Double.TryParse(input, out radius); // Пытаемся преобразовать введенную строку в число

                    if (!isNumber)
                    {
                        Console.WriteLine("Вы ввели не число. Необходимо ввести число.");
                        Console.WriteLine("Нажмите Enter для продолжения");
                        Console.ReadLine();
                        Console.Clear(); // Если введено не число, выводим сообщение об ошибке и очищаем консоль
                    }

                    if (radius <= 0)
                    {
                        Console.WriteLine("Введите положительное число");
                        Console.WriteLine("Нажмите Enter для продолжения");
                        Console.ReadLine();
                        Console.Clear(); // Если введено не число, выводим сообщение об ошибке и очищаем консоль
                    }
                }

                while (!isNumber || radius <= 0); // Повторяем цикл, пока не будет введено корректное положительное число

                double square = (Math.PI * Math.Pow(radius, 2)); // Вычисляем площадь круга, используя формулу S=π*r^2
                Console.WriteLine($"Площадь круга {square}"); // Выводим площадь круга на консоль.
                Console.WriteLine("-------------------------------------------");
            }
        }
    }
}
