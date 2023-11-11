using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint4.Task2.V1.Lib;

namespace Tyuiu.SavenkovaME.Sprint4.Task2.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                        *");
            Console.WriteLine("* Задание #2                                                                   *");
            Console.WriteLine("* Вариант #1                                                                   *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный случайными   *");
            Console.WriteLine("* в диапазоне от 1 до 9 подсчитать произведение четных элементов массива.      *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            
            int len = 10;
            int[] num = new int[len];
            Console.WriteLine("Длина массива = "+len);
            for (int i = 0; i <= num.Length - 1; i++)
            {
                num[i] = rnd.Next(1,10);
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");

            for (int i = 0; i <= num.Length - 1; i++)
            {
                Console.Write(num[i] + "    ");
            }
            Console.WriteLine();
            int res = ds.Calculate(num);
            Console.WriteLine();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Произведение четных элементов массива = " + res);

            Console.ReadKey();
        }
    }
}
