using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMethods
{
    internal class SpeedTest
    {
        const string LINQ_ORDERBY = "Linq OrderBy";
        const string BUBBLE_SORT = "Bubble Sort";
        const string QUICKSORT = "Quicksort";
        const string MERGESORT = "Mergesort";

        public static void TestAlgorithims(int minElements, int maxElements)
        {
            int[] testArray = generateRandomArray(minElements, maxElements);

            //Console.WriteLine($"Length of Array: {testArray.Length}");

            Stopwatch stopWatch = new();

            testLinqSort(ref testArray, stopWatch);
            testBubbleSort(ref testArray, stopWatch);
            testQuickSort(ref testArray, stopWatch);
            testMergeSort(ref testArray, stopWatch);
        }

        private static void testMergeSort(ref int[] testArray, Stopwatch stopWatch)
        {
            stopWatch.Start();
            MergeSortAlgorithm.MergeSort(testArray, false);
            stopWatch.Stop();

            writeResults(stopWatch, MERGESORT, testArray.Length);
            stopWatch.Reset();
        }

        private static void testQuickSort(ref int[] testArray, Stopwatch stopWatch)
        {
            stopWatch.Start();
            QuickSortAlgorithm.QuickSort(testArray);
            stopWatch.Stop();

            writeResults(stopWatch, QUICKSORT, testArray.Length);
            stopWatch.Reset();
        }

        private static void testBubbleSort(ref int[] testArray, Stopwatch stopWatch)
        {
            stopWatch.Start();
            BubbleSortAlgorithm.BubbleSort(testArray, false);
            stopWatch.Stop();

            writeResults(stopWatch, BUBBLE_SORT, testArray.Length);
            stopWatch.Reset();
        }

        private static void testLinqSort(ref int[] testArray, Stopwatch stopWatch)
        {
            stopWatch.Start();
            testArray.OrderBy(x => x);
            stopWatch.Stop();

            writeResults(stopWatch, LINQ_ORDERBY, testArray.Length);
            stopWatch.Reset();
        }

        private static void writeResults(Stopwatch stopWatch, string sortingAlgorithim, int arrayLength)
        {
            TimeSpan ts = stopWatch.Elapsed;

            //string elapsedTime = String.Format($"Total Nanoseconds: {ts.TotalNanoseconds}");

            // Console.WriteLine($"Execution Time for {sortingAlgorithim} {elapsedTime}");
            Console.WriteLine($"{sortingAlgorithim} : {arrayLength} : {ts.TotalNanoseconds}");
        }

        private static int[] generateRandomArray(int minElements, int maxElements)
        {
            Random r = new();

            int count = r.Next(minElements, maxElements);
            int[] testArray = new int[count];
            int currentIndex = 0;

            while (currentIndex < count)
            {
                testArray[currentIndex] = r.Next(0, maxElements);
                currentIndex++;
            }

            return testArray;
        }
    }
}
