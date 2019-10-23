using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    public class Bubble_Sort
    {
        public void BubbleSort(int[] array)
        {
            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                for (int i = 0; i < partIndex; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Sorting.Swap(array, i, i + 1);
                    }
                }
            }
        }

    }
}
