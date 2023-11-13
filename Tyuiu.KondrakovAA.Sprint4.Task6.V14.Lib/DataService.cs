using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KondrakovAA.Sprint4.Task6.V14.Lib
{
    public class DataService : ISprint4Task6V14
    {
        public string[] Calculate(string[] arr) 
        {
            string[] resp = new string[arr.Length];
            int c = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > 3) {
                    resp[c] = arr[i];
                }
                c++;
            }
            return resp;
        }
    }
}
