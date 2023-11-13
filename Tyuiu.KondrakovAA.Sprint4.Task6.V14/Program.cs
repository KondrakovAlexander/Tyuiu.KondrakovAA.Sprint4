using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KondrakovAA.Sprint4.Task6.V14.Lib;

namespace Tyuiu.KondrakovAA.Sprint4.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService resp = new DataService();
            string[] arr = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };
            Console.Title = "Спринт #4 | Выполнил: Кондраков А.А. | СМАРТб 23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Кондраков Александр Артемович | СМАРТб 23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Январь\", \"Февраль\", \"Март\", \"Апрель\",     *");
            Console.WriteLine("* \"Май\", \"Июнь\", \"Июль\"], используя класс Array, выведите элементы        *");
            Console.WriteLine("* массива, длина которых больше 3 символа.                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string[] a = resp.Calculate(arr);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }
    }
}
