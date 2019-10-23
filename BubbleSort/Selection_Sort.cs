using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    public class Selection_Sort
    {
        public void SelectionSort(int[] array)
        {
            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                int largestAt = 0;
                for (int i = 1; i <= partIndex; i++)
                {
                    if (array[i] > array[largestAt])
                    {
                        largestAt = i;
                    }
                }
                Sorting.Swap(array, largestAt, partIndex);
            }
        }

    }
}
