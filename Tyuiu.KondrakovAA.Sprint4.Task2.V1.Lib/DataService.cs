using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KondrakovAA.Sprint4.Task2.V1.Lib
{
    public class DataService : ISprint4Task2V1
    {
        public int Calculate(int[] x) 
        {
            int resp = 1;
            for(int i = 0; i < x.Length; i++)
            {
                if(x[i] % 2 == 0)
                {
                    resp *= x[i];
                }
            }
            return resp;
        }
    }
}
