using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    public class Merge_Sort
    {
        public void MergeSort(int[] array)
        {
            int[] auxArray = new int[array.Length];
            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if (high <= low)
                {
                    return;
                }

                int mid = (high + low) / 2;
                Sort(low, mid);
                Sort(mid + 1, high);
                Merge(low, mid, high);
            }

            void Merge(int low, int mid, int high)
            {
                if (array[mid] <= array[mid + 1])
                {
                    return;
                }
                int i = low;
                int j = mid + 1;

                Array.Copy(array, low, auxArray, low, high - low + 1);
                for (int k = low; k <= high; k++)
                {
                    if (i > mid)
                    {
                        array[k] = auxArray[j++];
                    }
                    else if (j > high)
                    {
                        array[k] = auxArray[i++];
                    }
                    else if(auxArray[j] < auxArray[i])
                    {
                        array[k] = auxArray[j++];
                    }
                    else
                    {
                        array[k] = auxArray[i++];
                    }
                }
            }
        }
    }
}
