using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KondrakovAA.Sprint4.Task7.V26.Lib;

namespace Tyuiu.KondrakovAA.Sprint4.Task7.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService resp = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Кондраков А.А. | СМАРТб 23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Кондраков Александр Артемович | СМАРТб 23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"351268459614723\". Преобразуйте ее в  *");
            Console.WriteLine("* матрицу 5 на 3 и подсчитайте произведение четных чисел.                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(resp.Calculate(5, 3, "351268459614723"));
            Console.ReadKey();

        }
    }
}
