public class SimpleBinarySearch()
{
    public static void Main()
    {
        //create an array of 10 elements
        int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //value to search for

        int target = 2;
        int position = Array.BinarySearch(arr, target);
        if(position >=0)
        {
            Console.WriteLine("item =  {0} found at position = {1}",target,position+1);
        }
        else
        {
            Console.WriteLine("item not found");
        }
    }
}