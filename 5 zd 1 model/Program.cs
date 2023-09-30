using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_zd_1_model
{
    internal class Program
    {
        static void Main(string[] args)
        {
            age.age_vivod();
        }
        class age
        {
            public static void age_vivod()
            {
                int age;
                bool isNumber;
                do
                {
                    Console.WriteLine("Введите ваш возраст: ");
                    string input = Console.ReadLine(); // Считываем введенную строку
                    isNumber = int.TryParse(input, out age); // Пытаемся преобразовать введенную строку в число

                    if (!isNumber)
                    {
                        Console.WriteLine("Вы ввели не число. Необходимо ввести число.");
                        Console.WriteLine("Нажмите Enter для продолжения");
                        Console.ReadLine();
                        Console.Clear(); // Если введено не число, выводим сообщение об ошибке и очищаем консоль
                    }

                    if (age <= 0)
                    {
                        Console.WriteLine($"Вам не может быть столько лет {age}");
                        Console.WriteLine("Нажмите Enter для продолжения");
                        Console.ReadLine();
                        Console.Clear(); // Если введено не число, выводим сообщение об ошибке и очищаем консоль
                    }
                }
                while (!isNumber || age <= 0); // Повторяем 

                if (18 <= age)
                {
                    Console.WriteLine("Возраст подтверждён, вы можете сдавать на водительские права. ");
                }
                else
                {
                    Console.WriteLine("Вам нет 18 лет, вы не можете сдавать на водительские права.");
                }
            }
        }
    }
}
