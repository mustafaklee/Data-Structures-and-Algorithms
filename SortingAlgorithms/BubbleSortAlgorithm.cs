namespace SortingMethods
{
    public class BubbleSortAlgorithm
    {
        public static int[] BubbleSort(int[] array, bool ascending)
        {
            //Returning early as you need at least two numbers to swap
            if (array.Length <= 1)
            {
                return array;
            }

            //The maximum number of swaps possible
            int maxSwapCount = array.Length - 1;

            //Iterate through all elements in the array
            for (int i = 0; i < maxSwapCount; i++)
            {
                /*Iterates through the newly swapped array, with each
                  iteration at least 1 element will be in the correct place*/
                for (int j = 0; j < maxSwapCount - i; j++)
                {
                    int currentNumber = array[j];

                    int nextIndex = j + 1;
                    int nextNumber = array[nextIndex];

                    if ((ascending && currentNumber > nextNumber) || currentNumber < nextNumber)
                    {
                        array[j] = nextNumber;
                        array[nextIndex] = currentNumber;
                    }

                }
            }

            return array;
        }
    }
}
