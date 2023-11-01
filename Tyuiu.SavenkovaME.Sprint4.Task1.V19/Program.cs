using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint4.Task1.V19.Lib;

namespace Tyuiu.SavenkovaME.Sprint4.Task1.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                                *");
            Console.WriteLine("* Задание #1                                                                   *");
            Console.WriteLine("* Вариант #19                                                                  *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный значениями   *");
            Console.WriteLine("* с клавиатуры в диапазоне от 2 до 9 подсчитать сумму четных элементов массива *");
            Console.WriteLine("* С клавиатуры: 6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7, 4                             *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Введите длину массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[len];
            for (int i = 0; i <= num.Length-1; i++)
            {
                Console.WriteLine("Введите значение " + i + " элемента: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine("Сумма четных элементов массива = " + res);

            Console.ReadKey();
        }
    }
}
