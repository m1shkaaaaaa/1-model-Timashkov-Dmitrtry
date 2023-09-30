using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_zd_1_model
{
    internal class Program
    {
        static void Main(string[] args)
        {
            array.array_vivod();
        }
        class array
        {
            public static void array_vivod()
            {
                Random random = new Random();// Создаем генератор случайных чисел.

                int[] numbers = new int[20];// Создаем массив из 20 случайных чисел.

                for (int i = 0; i < 20; i++)
                {
                    numbers[i] = random.Next(0, 100); // Генерируем случайное число от 1 до 100.
                }

                // Ищем максимальное и минимальное значение в массиве.
                int max = numbers[0];
                int min = numbers[0];

                foreach (int number in numbers)
                {
                    if (number > max)
                    {
                        max = number;
                    }

                    if (number < min)
                    {
                        min = number;
                    }
                }
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Случайный массив из 20 чисел:"); // Выводим результаты на экран.
                foreach (int number in numbers)
                {
                    Console.WriteLine($" [{number}] ");
                }

                Console.WriteLine();
                Console.WriteLine($"Максимальное значение: {max}");
                Console.WriteLine($"Минимальное значение: {min}");
                Console.WriteLine("-------------------------------------------");

            }
        }
    }
}
