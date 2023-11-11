using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint4.Task7.V4.Lib;

namespace Tyuiu.SavenkovaME.Sprint4.Task7.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                      *");
            Console.WriteLine("* Задание #7                                                                   *");
            Console.WriteLine("* Вариант #4                                                                   *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 382976421897. Преобразуйте ее в матрицу    *");
            Console.WriteLine("* 3 на 4 и подсчитайте сумму нечетных чисел.                                   *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("\nМассив:");
            int n = 3;
            int m = 4;
            string value = "382976421897";
            
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(value[index] + "\t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int res = ds.Calculate(n, m, value);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Сумма нечетных чисел = " + res);
            Console.ReadKey();
        }
    }
}
