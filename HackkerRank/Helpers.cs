using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackkerRank
{
    public static class Helpers
    {
        public static bool isPositive(this int number)
        {
            return number > 0;
        }

        public static bool isNegative(this int number)
        {
            return number < 0;
        }

        public static bool isZero(this int number)
        {
            return number == 0;
        }
    }
}
