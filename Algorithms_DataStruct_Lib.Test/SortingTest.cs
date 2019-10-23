using NUnit.Framework;
using Sorting_Algorithms;
using System;

namespace Algorithms_DataStruct_Lib.Test
{
    [TestFixture]
    public class SortingTests
    {        
        private int[][] Samples()
        {
            int[][] samples = new int[9][];
            samples[0] = new[] { 1 };
            samples[1] = new[] { 2, 1 };
            samples[2] = new[] { 2, 1, 3 };
            samples[3] = new[] { 1, 1, 1 };
            samples[4] = new[] { 2, -1, 3, 3 };
            samples[5] = new[] { 4, -5, 3, 3 };
            samples[6] = new[] { 0, -5, 3, 3 };
            samples[7] = new[] { 0, -5, 3, 0 };
            samples[8] = new[] { 3, 2, 5, 5, 1, 0, 7, 8 };

            return samples;
        }
        
        private void RunTestsForSortAlgorithm(Action<int[]> sort)
        {
            foreach (var sample in Samples())
            {
                sort(sample);
                CollectionAssert.IsOrdered(sample);
                PrintOut(sample);
            }
        }

        private void PrintOut(int[] array)
        {
            TestContext.WriteLine("-----TRACE--------\n");
            foreach (var el in array)
            {
                TestContext.Write(el + " ");
            }
            TestContext.WriteLine("\n----------------\n");
        }

        [Test]
        public void BubbleSort_ValipInput_SortedInput()
        {
            var bubbleSort = new Bubble_Sort();
            RunTestsForSortAlgorithm(bubbleSort.BubbleSort);
        }

        [Test]
        public void SelectionSort_ValidInput_SortedOutput()
        {
            var selectionSort = new Selection_Sort();
            RunTestsForSortAlgorithm(selectionSort.SelectionSort);
        }

        [Test]
        public void InsertionSort_ValidInput_SortedOutPut()
        {
            var insertionSort = new Insertion_Sort();
            RunTestsForSortAlgorithm(insertionSort.InsertionSort);
        }

        [Test]
        public void ShellSort_ValidInput_SortedOutPut()
        {
            var shellSort = new Shell_Sort();
            RunTestsForSortAlgorithm(shellSort.ShellSort);
        }

        [Test]
        public void MergeSort_ValidInput_SortedOutPut()
        {
            var mergeSort = new Merge_Sort();
            RunTestsForSortAlgorithm(mergeSort.MergeSort);
        }

        [Test]
        public void QuickSort_ValidInput_SortedOutPut()
        {
            var quickSort = new Quick_Sort();
            RunTestsForSortAlgorithm(quickSort.QuickSort);
        }
    }
}
