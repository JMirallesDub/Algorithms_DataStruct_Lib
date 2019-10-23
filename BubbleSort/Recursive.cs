using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    public class Recursive
    {
        public double RecursiveFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * RecursiveFactorial(n - 1);
        }

        public long IterativeFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            long factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

    }
}
