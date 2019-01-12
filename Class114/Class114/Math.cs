using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class114
{
    class Math
    {
        public static int SubtractThree(int x = 8)
        {
            int difference = x - 3;
            return difference;

        }
        public static decimal SubtractThree(decimal x = 8.5m)
        {
            decimal product = x * 10;
            return product;
        }
        public static string SubtractThree(string x = "five")
        {
            int y = Convert.ToInt32(x);
            int sum = y + 1;
            return sum.ToString();
        }

}
}
