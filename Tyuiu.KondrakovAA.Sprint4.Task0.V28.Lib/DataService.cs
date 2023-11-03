using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KondrakovAA.Sprint4.Task0.V28.Lib
{
    public class DataService : ISprint4Task0V28
    {
        public int GetMultEvenArrEl(int[] arr)
        {
            int resp = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) 
                {
                    resp *= arr[i];
                }
            }
            return resp;
        }
    }
}
