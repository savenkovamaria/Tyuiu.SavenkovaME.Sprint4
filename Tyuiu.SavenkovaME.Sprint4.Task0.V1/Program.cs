using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint4.Task0.V1.Lib;

namespace Tyuiu.SavenkovaME.Sprint4.Task0.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                                  *");
            Console.WriteLine("* Задание #0                                                                   *");
            Console.WriteLine("* Вариант #1                                                                   *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный статическими *");
            Console.WriteLine("* значениями в диапазоне от 0 до 9 подсчитать сумму четных элементов массива.  *");
            Console.WriteLine("* {6 ,4 ,3 ,2 ,1 ,0 ,9 ,8 ,7 ,5}                                               *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            int[] num = { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };
            int res = ds.GetSumEvenArrEl(num);
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= num.Length-1; i++)
            {
                Console.WriteLine(num[i]);
            }

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Сумма четных элементов массива = " + res);

            Console.ReadKey();
        }
    }
}
