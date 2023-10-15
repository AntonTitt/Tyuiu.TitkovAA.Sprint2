using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TitkovAA.Sprint2.Task4.V0.Lib
{
    public class DataService : ISprint2Task4V14
    {
        public double Calculate(double x, double y)
        {
            return Math.Round((x * 3) < (Math.Sqrt(y) + 20) ? Math.Pow((2 + (1) / (x * x)), y) : ((y * y) - (Math.Cos(x) * Math.Cos(x)) + 10) / ((x * x) - (Math.Sin(y) * Math.Sin(y)) + 12), 3);
        }
    }
}
