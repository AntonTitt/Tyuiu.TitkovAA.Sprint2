using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TitkovAA.Sprint2.Task1.V0.Lib
{
    public class DataService:ISprint2Task1V17
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] v = new bool[6];
            v[0] = (a > b) | (c > d);
            v[1] = (a < b) & (c < d);
            v[2] = (a == b) || (c != d);
            v[3] = (a > b) && (c > d);
            v[4] = !v[1];
            v[5] = !v[4];
            return v;//(True, False, True, True, True, False) a = 135, b = 123, c = 455, d = 321
        }
    }
}
