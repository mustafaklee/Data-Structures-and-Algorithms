using SortingMethods;

public class SortingAlgorithms()
{
    public static void Main()
    {
        // Array.Sort() quick sort veya merge sort kullanılır.
        int[] arr = new int[5] { 64, 25, 12, 22, 11 };

        Array.Sort(arr);
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }



        //List<T>.Sort() quick sort kullanılır
        List<int> list = new List<int> { 3, 5, 6, 1, 24, 5, 67, 7, 4, 2 };
        list.Sort();

        foreach (int item in list)
        {
            Console.Write(item + " ");
        }



        //OrderBy sorting
        List<int> list2 = new List<int> { 64, 25, 12, 22, 11 };
        var sortedList = list2.OrderBy(x => x);
        Console.WriteLine("Sorted list:");
        foreach (var item in sortedList)
        {
            Console.Write(item + " ");
        }



        //BubbleSort Complexity  O(N²)
        Console.WriteLine("BubbleSortAlgorithm");
        BubbleSortAlgorithm.BubbleSort(list2.ToArray(), true);

        int[] arr3 = new int[5] { 1, 145, 3, 555, 7 };


        //QuickSort Complexity O(n*log(n))
        Console.WriteLine("QuickSortAlgorithm");
        QuickSortAlgorithm.QuickSort(arr3);


        //MergeSort Complexity O(nLogn)
        Console.WriteLine("MergeSortAlgorithm");
        MergeSortAlgorithm.MergeSort(arr3,false);


        Console.WriteLine("-------SpeedTest------");
        SpeedTest.TestAlgorithims(1000,2000);

    }
}