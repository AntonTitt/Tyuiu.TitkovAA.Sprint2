using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TitkovAA.Sprint2.Task3.V0.Lib
{
    public class DataService : ISprint2Task3V6
    {
        public double Calculate(double x)
        {
            if (x > 0) return (x + Math.Pow((x - 15) / (x - 10), x - 3));
            else if (x == 0) return (((x * x) - (Math.Cos(x) * Math.Cos(x)) + 10) / ((x * x) - (Math.Sin(x) * Math.Sin(x)) + 12));
            else if (-10 < x && x < 0) return (Math.Pow(x, 4) + (1 / (x * x)));
            else if (x < -10) return (x + 10 * x - (1 / x));
            return 0;
        }
    }
}
