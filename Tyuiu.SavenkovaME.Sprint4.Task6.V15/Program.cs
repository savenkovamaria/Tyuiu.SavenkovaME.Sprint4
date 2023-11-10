using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint4.Task6.V15.Lib;

namespace Tyuiu.SavenkovaME.Sprint4.Task6.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Тема: Класс Array                                                            *");
            Console.WriteLine("* Задание #6                                                                   *");
            Console.WriteLine("* Вариант #15                                                                  *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан строковый массив данных [Чикаго, Хьюстон, Феникс, Филадельфия,           *");
            Console.WriteLine("* Сан - Антонио, Сан - Диего, Даллас] используя класс Array подсчитайте        *");
            Console.WriteLine("* количество элементов, длина которых меньше 7.                                *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            var array = new string[] { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine("Количество элементов, длина которых меньше 7 = " + res);

            Console.ReadKey();
        }
    }
}
