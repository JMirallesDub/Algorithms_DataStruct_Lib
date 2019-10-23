using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    public class Shell_Sort
    {
        public void ShellSort(int[] array)
        {
            int gap = 1;
            while (gap < array.Length /3)
            {
                gap = 3 * gap + 1;
            }

            while (gap >= 1)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    for (int j = i; j >= gap && array[j] < array[j -gap]; j -= gap)
                    {
                        Sorting.Swap(array, j, j - gap);
                    }
                }
                gap /= 3;
            }
        }
    }
}
