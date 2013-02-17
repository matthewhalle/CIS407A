using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassCalc
{
    public class ulator
    {
        public static int Divide(string x, string y)
        {
            return int.Parse(x) / int.Parse(y);
        }
        public static string Add(string x, string y)
        {
            return (int.Parse(x) + int.Parse(y)).ToString();
        }
    }
}
