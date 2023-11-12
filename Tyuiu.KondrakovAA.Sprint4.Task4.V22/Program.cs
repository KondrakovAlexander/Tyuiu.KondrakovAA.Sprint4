using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KondrakovAA.Sprint4.Task4.V22.Lib;

namespace Tyuiu.KondrakovAA.Sprint4.Task4.V22
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #22                                                              *");
            Console.WriteLine("* Выполнил: Кондраков Александр Артемович | СМАРТб 23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 6. Заменить нечетные        *");
            Console.WriteLine("* элементы массива на 0.                                                  *");
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
            Console.WriteLine("* 4, 3, 2, 4, 5,                                                          *");
            Console.WriteLine("* 5, 4, 5, 6, 6,                                                          *");
            Console.WriteLine("* 6, 2, 3, 6, 5,                                                          *");
            Console.WriteLine("* 6, 2, 3, 6, 4,                                                          *");
            Console.WriteLine("* 6, 2, 6, 6, 2,                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            arr = resp.Calculate(arr);
            for (int i = 0; i < 5; i++)
            {
                string a = "";
                for (int j = 0; j < 5; j++)
                {
                    a += Convert.ToString(arr[i, j]);
                }
                Console.WriteLine(a + "\n");
                a = "";
            }
            Console.ReadKey();
        }
    }
}
