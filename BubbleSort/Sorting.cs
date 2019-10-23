using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    public class Sorting
    {
        public static void Swap(int[] array, int i, int j)
        {
            if (i == j)
            {
                return;
            }
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

    }
}
