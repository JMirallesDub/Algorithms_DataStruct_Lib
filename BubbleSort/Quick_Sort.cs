using System;
using System.Collections.Generic;
using System.Text;


/// <summary>
/// Divide and Conquer.
/// Recursive.
/// Splitting base on pivot elements. (Pivot is always the first element).
/// Elements < pivot go to its left
/// Elements > pivot go to its right
/// </summary>
namespace Sorting_Algorithms
{
    public class Quick_Sort
    {
        public void QuickSort(int[] array)
        {
            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if (high <= low)
                {
                    return;
                }
                int j = Partition(low, high);
                Sort(low, j - 1);
                Sort(j + 1, high);
            }

            int Partition(int low, int high)
            {
                int i = low;
                int j = high + 1;

                int pivot = array[low];
                while (true)
                {
                    while (array[++i] < pivot)
                    {
                        if (i == high)
                        {
                            break;
                        }
                    }
                    while (pivot < array[--j])
                    {
                        if (j == low)
                        {
                            break;
                        }
                    }

                    if (i >= j)
                    {
                        break;
                    }

                    Sorting.Swap(array, i, j);
                }
                Sorting.Swap(array, low, j);

                return j;
            }
        }
    }
}
