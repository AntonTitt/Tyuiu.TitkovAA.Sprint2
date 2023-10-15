using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TitkovAA.Sprint2.Task0.V0.Lib
{
    public class DataService:ISprint2Task0V11
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] a = new bool[6];
            a[0] = x - 7830 == y;
            a[1] = x - 7830 != y;
            a[2] = y < x;
            a[3] = y > x;
            a[4] = y <= x;
            a[5] = y >= x;

            return a;
        }
    }
}
