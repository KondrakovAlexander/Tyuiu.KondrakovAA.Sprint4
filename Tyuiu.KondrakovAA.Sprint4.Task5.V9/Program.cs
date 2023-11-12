using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KondrakovAA.Sprint4.Task5.V9.Lib;

namespace Tyuiu.KondrakovAA.Sprint4.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService resp = new DataService();
            int[,] arr = new int[5, 5] { { 4, 3, 2, 4, 5, }, { 5, 4, 5, 6, 6, }, { 6, 2, 3, 6, 5, }, { 6, 2, 3, 6, 4, }, { 6, 2, 6, 6, 2, } };
            Console.Title = "Спринт #4 | Выполнил: Кондраков А.А. | СМАРТб 23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Кондраков Александр Артемович | СМАРТб 23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -4 до 4. Найти количество          *");
            Console.WriteLine("* положительных элементов.                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив: ");
            Console.WriteLine("* 4, 3, 2, 4, 5,                                                          *");
            Console.WriteLine("* 5, 4, 5, 6, 6,                                                          *");
            Console.WriteLine("* 6, 2, 3, 6, 5,                                                          *");
            Console.WriteLine("* 6, 2, 3, 6, 4,                                                          *");
            Console.WriteLine("* 6, 2, 6, 6, 2,                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(resp.Calculate(arr));
            Console.ReadKey();
        }
    }
}
