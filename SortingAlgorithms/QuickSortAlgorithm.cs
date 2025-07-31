namespace SortingMethods
{
    public class QuickSortAlgorithm
    {
        public static int[] QuickSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            return QuickSort(array, 0, array.Length - 1);
        }

        static int[] QuickSort(int[] array, int leftIndex, int rightIndex)
        {
            int pivot = array[leftIndex];
            int currentLeftIndex = leftIndex;
            int currentRightIndex = rightIndex;

            //While the two sorting indices don't meet, this is to localise the sorting to a given range and essential define our partition for the Quick Sort
            while (currentLeftIndex <= currentRightIndex)
            {
                /* Comparing if the left value is less than the pivot value
                   then moving the left index along until the left value >= the pivot*/
                while (array[currentLeftIndex] < pivot)
                {
                    currentLeftIndex++;
                }

                /* Comparing if the right value is greater than the pivot value
                 then moving the right index along until it is <= the pivot value */
                while (array[currentRightIndex] > pivot)
                {
                    currentRightIndex--;
                }

                //Swap the values when the number on the left is less then the number on the right
                if (currentLeftIndex <= currentRightIndex)
                {
                    (array[currentRightIndex], array[currentLeftIndex]) = (array[currentLeftIndex], array[currentRightIndex]);
                    currentLeftIndex++;
                    currentRightIndex--;
                }
            }

            /*If the starting index on the left side is less than the current right index then sort again. This is done using our new indices that will act as a partition of the array and localise sorting to that range.
              as there are more swaps to be made before the array has been sorted */
            if (leftIndex < currentRightIndex)
            {
                QuickSort(array, leftIndex, currentRightIndex);
            }

            /*If the starting index on the right side is greater than the current left index then sort again. This is done using our new indices that will act as a partition of the array and localise sorting to that range.
              as there are more swaps to be made before the array has been sorted */
            if (rightIndex > currentLeftIndex)
            {
                QuickSort(array, currentLeftIndex, rightIndex);
            }

            return array;
        }


    }
}
