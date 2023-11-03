using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KondrakovAA.Sprint4.Task3.V13.Lib
{
    public class DataService : ISprint4Task3V13
    {
        public int Calculate(int[,] arr)
        {
            int resp = 0;
            for(int i = 0; i < 5; i++) 
            {
                resp += arr[2, i];
            }
            return resp;
        }
    }
}
