using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMethods
{
    public class MergeSortAlgorithm
    {
        public static int[] MergeSort(int[] array, bool ascending)
        {
            if (array.Length == 0)
            {
                return [];
            }

            //Determine the middle index of the array
            int middle = array.Length / 2;

            int[] leftArray = array.Take(middle).ToArray();
            int[] rightArray = array.Skip(middle).Take(array.Length - middle).ToArray();

            if (leftArray.Length > 1)
            {
                MergeSort(leftArray, ascending);
            }

            if (rightArray.Length > 1)
            {
                MergeSort(rightArray, ascending);
            }

            MergeArray(leftArray, rightArray, array, ascending);

            return array;
        }

        static void MergeArray(int[] leftArray, int[] rightArray, int[] sortedArray, bool ascending)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int sortedIndex = 0;

            while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
            {
                if (ascending)
                {
                    /* If sorting by ascending order we need to set the number in the sorted at
                       the current index to the lowest value between the two arrays */
                    sortedArray[sortedIndex++] = leftArray[leftIndex] <= rightArray[rightIndex] ?
                        leftArray[leftIndex++] :
                        rightArray[rightIndex++];
                }
                else
                {
                    /* If sorting by descending order we need to set the number in the sorted at
                        the current index to the highest value between the two arrays */
                    sortedArray[sortedIndex++] = leftArray[leftIndex] >= rightArray[rightIndex] ?
                        leftArray[leftIndex++] :
                        rightArray[rightIndex++];
                }
            }

            //If there are any missing elements in the swapped arrays then add them to the sorted array
            while (leftIndex < leftArray.Length)
            {
                sortedArray[sortedIndex++] = leftArray[leftIndex++];
            }

            while (rightIndex < rightArray.Length)
            {
                sortedArray[sortedIndex++] = rightArray[rightIndex++];
            }
        }
    }
}
