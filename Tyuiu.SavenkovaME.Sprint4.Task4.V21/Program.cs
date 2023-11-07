using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint4.Task4.V21.Lib;

namespace Tyuiu.SavenkovaME.Sprint4.Task4.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                                 *");
            Console.WriteLine("* Задание #4                                                                   *");
            Console.WriteLine("* Вариант #21                                                                  *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,заполненный значениями с *");
            Console.WriteLine("* клавиатуры в диапазоне от 3 до 8. Найдите сумму четных элементов массива.    *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("* 3, 6, 4, 6, 6,                                                               *");
            Console.WriteLine("* 7, 5, 5, 5, 8,                                                               *");
            Console.WriteLine("* 8, 3, 6, 7, 7,                                                               *");
            Console.WriteLine("* 5, 3, 8, 4, 5,                                                               *");
            Console.WriteLine("* 3, 7, 4, 3, 8,                                                               *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            int rows;
            Console.Write("Введите количество строк: ");
            rows = Convert.ToInt32(Console.ReadLine());
            int columns;
            Console.Write("Введите количество столбцов: ");
            columns = Convert.ToInt32(Console.ReadLine());
            int[,] num = new int[rows,columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Введите значение {i},{j} элемента: ");
                    num[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(num[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int res = ds.Calculate(num);
            
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (num[i,j] >= 3 && num[i,j] <= 8)
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            if (count == (columns*rows))
            {
                Console.WriteLine("Сумма четных элементов массива = " + res);
            }
            else
            {
                Console.WriteLine("Значения, не принадлежат диапазону от 3 до 8");
            }

            Console.ReadKey();
        }
    }
}
