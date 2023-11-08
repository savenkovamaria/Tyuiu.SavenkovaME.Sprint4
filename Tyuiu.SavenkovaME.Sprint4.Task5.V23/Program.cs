using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint4.Task5.V23.Lib;

namespace Tyuiu.SavenkovaME.Sprint4.Task5.V23
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
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                         *");
            Console.WriteLine("* Задание #5                                                                   *");
            Console.WriteLine("* Вариант #23                                                                  *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайными  *");
            Console.WriteLine("* значениями в диапазоне от -4 до 8. Заменить отрицательные элементы на 0.     *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            int rows = 5;
            int columns = 5;
            int[,] matrix = new int[rows, columns];
            Console.WriteLine("Количество строк = " + rows);
            Console.WriteLine("Количество столбцов = " + columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rnd.Next(-4, 8);
                }
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int[,] res = ds.Calculate(matrix);
            Console.WriteLine();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(res[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
