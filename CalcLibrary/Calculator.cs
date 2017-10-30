using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    public class Calculator
    {
        public string Sum(string x, string y)
        {
            double xd, yd;

            if (!double.TryParse(x, out xd))
                return "error";

            if (!double.TryParse(y, out yd))
                return "error";

            double result = xd + yd;
            return $"{result}";
        }
    }
}
