using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TitkovAA.Sprint2.Task2.V0.Lib
{
    public class DataService : ISprint2Task2V16
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool r = false;
            if ((y == 3 || ((x >= 3 && x <= 5) || (x == 13) || (x == 14))) || (y == 4 || ((x >= 3 && x <= 5) || (x == 13) || (x == 14))) || (y == 5 || ((x >= 3 && x <= 7) || (x == 13) || (x == 14))) ||
                (y == 6 || ((x >= 3 && x <= 9) || (x == 13) || (x == 14))) || (y == 7 || ((x >= 3 && x <= 14) )) || (y == 8 || ((x >= 6 && x <= 9) || (x == 13) || (x == 14))) ||
                (y == 9 || ((x >= 6 && x <= 7) || (x == 13) || (x == 14))) || (y == 10 || ((x >= 6 && x <= 7) || (x == 13) || (x == 14))) || (y == 11 || ((x >= 3 && x <= 7) )) ||
                (y == 12 || ((x >= 7 && x <= 10) || x == 3 )) || (y == 13 || ((x >= 10 && x <= 12) || x == 3 )))
            {
                r = true;
            }

            return r;
        }
    }
}
