using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KondrakovAA.Sprint4.Task0.V28.Lib;

namespace Tyuiu.KondrakovAA.Sprint4.Task0.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService resp = new DataService();
            int[] arr = new int[] { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            Console.Title = "Спринт #4 | Выполнил: Кондраков А. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Кондраков А.А | СМАРТб-23-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* ан одномерный целочисленный массив на 10 элементов заполненный          *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать произведение   *");
            Console.WriteLine("* четных элементов массива.  {9, 8, 4, 6, 9, 4, 3, 6, 1, 2}               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Массив элементов {9, 8, 4, 6, 9, 4, 3, 6, 1, 2}                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(resp.GetMultEvenArrEl(arr));
            Console.ReadLine();
        }
    }
}
