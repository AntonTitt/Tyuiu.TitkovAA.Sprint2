using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TitkovAA.Sprint2.Task5.V0.Lib
{
    public class DataService : ISprint2Task5V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            StringBuilder a = new StringBuilder();

            switch (m)
            {

                case 1: if (n > 1) a.Append(Convert.ToString(n - 1) + " месяц: январь"); else a.Append("31 месяц: декабрь"); break;
                case 2: if (n > 1) a.Append(Convert.ToString(n - 1) + " месяц: февраль"); else a.Append("31 месяц: январь"); break;
                case 3: if (n > 1) a.Append(Convert.ToString(n - 1) + " месяц: март"); else a.Append("28 месяц: февраль"); break;
                case 4: if (n > 1) a.Append(Convert.ToString(n - 1) + " месяц: апрель"); else a.Append("31 месяц: март"); break;
                case 5: if (n > 1) a.Append(Convert.ToString(n - 1) + " месяц: май"); else a.Append("30 месяц: апрель"); break;
                case 6: if (n > 1) a.Append(Convert.ToString(n - 1) + " месяц: июнь"); else a.Append("31 месяц: май"); break;
                case 7: if (n > 1) a.Append(Convert.ToString(n - 1) + " месяц: июль"); else a.Append("30 месяц: июнь"); break;
                case 8: if (n > 1) a.Append(Convert.ToString(n - 1) + " месяц: август"); else a.Append("31 месяц: июль"); break;
                case 9: if (n > 1) a.Append(Convert.ToString(n - 1) + " месяц: сентябрь"); else a.Append("31 месяц: август"); break;
                case 10: if (n > 1) a.Append(Convert.ToString(n - 1) + " месяц: октябрь"); else a.Append("30 месяц: сентябрь"); break;
                case 11: if (n > 1) a.Append(Convert.ToString(n - 1) + " месяц: ноябрь"); else a.Append("31 месяц: октябрь"); break;
                case 12: if (n > 1) a.Append(Convert.ToString(n - 1) + " месяц: декабрь"); else a.Append("30 месяц: ноябрь"); break;

            }

            return "год: " + Convert.ToString(g) + " день: " + Convert.ToString(a);
        }
    }
}
