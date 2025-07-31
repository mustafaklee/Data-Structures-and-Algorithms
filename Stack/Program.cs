using System.Collections;

public class SamplesStack
{
    public static void Main()
    {
        //create stack
        Stack mystack = new Stack();


        //initialize stack
        mystack.Push("hello");
        mystack.Push("world");
        mystack.Push("!");


        //return the object at the top without remove
        Console.WriteLine(mystack.Peek());

        //get stack element
        PrintValues(mystack);







        //an example with generic stack
        Stack<string> numbers = new Stack<string>();

        numbers.Push("one");
        numbers.Push("two");
        numbers.Push("three");
        numbers.Push("four");
        numbers.Push("five");

        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }


        // Create a copy of the stack, using the ToArray method and the
        // constructor that accepts an IEnumerable<T>.
        Stack<string> stack2 = new Stack<string>(numbers.ToArray());

        foreach(string number in stack2)
        {
            Console.WriteLine(number);
        }

        //copyTo starting at the specified array index 
        string[] array2 = new string[numbers.Count * 2];
        numbers.CopyTo(array2,numbers.Count);

        foreach (string number in array2)
        {
            Console.WriteLine(number);
        }

        // Create a second stack, using the constructor that accepts an IEnumerable(Of T)
        //Contents of the second copy, with duplicates and nulls
        Stack<string> stack3 = new Stack<string>(array2);
        
        foreach(string obj in stack3)
        {
            Console.WriteLine(obj);
        }


        Console.WriteLine(stack3.Contains(null));
        Console.WriteLine(stack3.Count());
        stack3.Clear();
        Console.WriteLine(stack3.Count());

    }


    public static void PrintValues(IEnumerable myCollection)
    {
        foreach(Object obj in myCollection)
            Console.WriteLine("{0}",obj);
    }


}