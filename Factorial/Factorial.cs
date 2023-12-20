using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialProject
{
    public static class Factorial
    {
        public static long Calculate(long n)
        {
            if(n < 0)
                throw new ArgumentOutOfRangeException($"{n} lower then 0!");

            if (n == 0)
                return 1;
            else
                return n * Calculate(n - 1);
        }
    }
}
