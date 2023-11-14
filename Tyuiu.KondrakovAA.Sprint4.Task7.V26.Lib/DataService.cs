using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KondrakovAA.Sprint4.Task7.V26.Lib
{
    public class DataService : ISprint4Task7V26
    {
        public int Calculate(int a, int b, string c)
        {
            int[,] matr = new int[5, 3];
            int counter = 0;
            int resp = 1;
            int[] arr = c.ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();

            for (int i = 0; i < 5; i++) 
            {
                for (int j = 0; j < 3; j++)
                {
                    matr[i, j] = arr[counter];
                    if(matr[i,j] % 2 == 0)
                    {
                        resp *= matr[i, j];
                    }
                    counter++;

                }
            }

            return resp;
        }
    }
}
