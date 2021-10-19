using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumIndexerExtensions
{
    static class Extensions
    {
        public static bool IsFirstCharUpper(this string text)
        {
            return char.IsUpper(text, 0);
        }

        public static double GetPower(this double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}
