using System.Collections;


public class SimpleQueue
{
    public static void Main()
    {
        //create a new queue
        Queue myQ = new Queue();
        myQ.Enqueue("hello");
        myQ.Enqueue("world");
        myQ.Enqueue("!");

        Console.WriteLine(myQ.Count);
        PrintValues(myQ);


        //an example using the system.collections.generic

        Queue<String> numbers = new Queue<string>();
        numbers.Enqueue("one");
        numbers.Enqueue("two");
        numbers.Enqueue("three");
        numbers.Enqueue("four");
        numbers.Enqueue("five");

        foreach(string number in numbers)
        {
            Console.WriteLine(number);
        }


        //return the object beginning of the queue without removing it
        numbers.Peek();


        //removed and return the object at the beginning of the queue
        numbers.Dequeue();
        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }


        Queue<string> queueCopy = new (numbers.ToArray());

        foreach (string number in queueCopy)
        {
            Console.WriteLine(number);
        }


        string[] array2 = new string[numbers.Count * 2];
        numbers.CopyTo(array2, numbers.Count);

        Queue<string> queueCopy2 = new Queue<string>(array2);


        foreach (string number in queueCopy2)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine(queueCopy.Contains("four"));

        queueCopy.Clear();

    }




    public static void PrintValues(IEnumerable myCollection)
    {
        foreach (object obj in myCollection)
            Console.WriteLine("{0}", obj);
    }
}