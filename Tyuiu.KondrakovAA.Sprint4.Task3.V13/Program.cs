using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KondrakovAA.Sprint4.Task3.V13.Lib;

namespace Tyuiu.KondrakovAA.Sprint4.Task3.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService resp = new DataService();
            int[,] arr = new int[5, 5] { { 4, 7, 4, 2, 1 }, { 6, 7, 3, 6, 5 }, { 6, 5, 3, 3, 5 }, { 4, 4, 6, 4, 7 }, { 2, 1, 2, 3, 4 } };
            Console.Title = "Спринт #4 | Выполнил: Кондраков А.А. | СМАРТб 23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Кондраков Александр Артемович | СМАРТб 23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 7. Найдите сумму элементов  *");
            Console.WriteLine("* в третьем столбце массива                                               *");
            Console.WriteLine("* 4, 7, 4, 2, 1,                                                          *");
            Console.WriteLine("* 6, 7, 3, 6, 5,                                                          *");
            Console.WriteLine("* 6, 5, 3, 3, 5,                                                          *");
            Console.WriteLine("* 4, 4, 6, 4, 7,                                                          *");
            Console.WriteLine("* 2, 1, 2, 3, 4,                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив: ");
            Console.WriteLine("* 4, 7, 4, 2, 1,                                                          *");
            Console.WriteLine("* 6, 7, 3, 6, 5,                                                          *");
            Console.WriteLine("* 6, 5, 3, 3, 5,                                                          *");
            Console.WriteLine("* 4, 4, 6, 4, 7,                                                          *");
            Console.WriteLine("* 2, 1, 2, 3, 4,                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(resp.Calculate(arr));
            Console.ReadKey();
        }
    }
}
