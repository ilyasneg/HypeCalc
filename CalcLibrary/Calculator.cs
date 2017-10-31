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

            if (!double.TryParse(x, out xd) || !double.TryParse(y, out yd))
                return "error";

            double result = xd + yd;
            return $"{result}";
        }

        public double Sub(string x, string y)
        {
            double xd, yd;

            if (!double.TryParse(x, out xd) || !double.TryParse(y, out yd))
                throw new Exception("Данные введены неверно");

            double result = xd - yd;
            return result;
        }

        public double Mult(string x, string y)
        {
            double xd, yd;

            if (!double.TryParse(x, out xd) || !double.TryParse(y, out yd))
                throw new Exception("Данные введены неверно");

            double result = xd * yd;
            return result;
        }

        public double Div(string x, string y)
        {
            double xd, yd;

            if (!double.TryParse(x, out xd) || !double.TryParse(y, out yd))
                throw new Exception("Данные введены неверно");

            if (Equals(yd, 0.0))
                throw new Exception("Деление на ноль невозможно");

            double result = xd / yd;
            return result;
        }

        public double Pow(string x, string y)
        {
            double xd, yd;

            if (!double.TryParse(x, out xd) || !double.TryParse(y, out yd))
                throw new Exception("Данные введены неверно");

            double result = Math.Pow(xd, yd);
            return result;
        }

        public double Mod(string x, string y)
        {
            double xd, yd;

            if (!double.TryParse(x, out xd) || !double.TryParse(y, out yd))
                throw new Exception("Данные введены неверно");

            if (Equals(yd, 0.0))
                throw new Exception("Результат не определен");

            double result = xd % yd;
            return result;
        }
    }
}
