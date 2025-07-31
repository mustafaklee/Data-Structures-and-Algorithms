using System.Text;

public class Example()
{
    public static void Main()
    {
        //create the link list

        string[] words = {"the", "fox", "jumps", "over", "the", "dog" };

        LinkedList<string> sentence =new LinkedList<string>(words);
        Display(sentence,"linked list values");
        Console.WriteLine("sentence contains jump ? {0}",sentence.Contains("jumps"));

        //add to word link list
        sentence.AddFirst("today");
        Display(sentence, "add today to beginning of the list");


        //move the first node to be the last node
        LinkedListNode<string> mark1 = sentence.First;
        sentence.RemoveFirst();
        sentence.AddLast(mark1);
        Display(sentence, "move first node to be the last node");

        //change the last node to yesterday
        sentence.RemoveLast();
        sentence.AddLast("yesterday");
        Display(sentence, "change the last node to yesterday");

        //ındicate the last occurence of 'the'
        LinkedListNode<string> current = sentence.FindLast("the");
        IndicateNode(current, "indicate the last occurence of 'the'");

        //add 'lazy' and 'old' after 'the'
        sentence.AddAfter(current, "lazy");
        sentence.AddAfter(current, "old");
        IndicateNode(current, "add 'lazy' and 'old' after 'the'");

        //indicate 'fox' node 
        current = sentence.Find("fox");
        IndicateNode(current, "indicate 'fox' node ");

        // Add 'quick' and 'brown' before 'fox':
        sentence.AddBefore(current, "quick");
        sentence.AddBefore(current, "brown");
        IndicateNode(current, "Add 'quick' and 'brown' before 'fox'");

        // The AddBefore method throws an InvalidOperationException
        // if you try to add a node that already belongs to a list
        current = sentence.Find("dog");
        mark1 = current;
        Console.WriteLine(" The AddBefore method throws an InvalidOperationException if you try to add a node that already belongs to a list");
        try
        {
            sentence.AddBefore(current,mark1);
        }
        catch(InvalidOperationException ex)
        {
            Console.WriteLine("exception message: "+ex.Message);
        }

        // Remove the node referred to by current.
        sentence.Remove(current);
        IndicateNode(current, "Remove current node (dog) and attempt to indicate it");

        sentence.Clear();

        Console.WriteLine("Clear linked list Contains 'jumps' = {0}",
            sentence.Contains("jumps"));

    }


    public static void Display(LinkedList<string> words, string test)
    {
        Console.WriteLine(test);

        foreach (string word in words) {
            Console.WriteLine(word+" ");
        }
    }




    public static void IndicateNode(LinkedListNode<string> node , string test)
    {
        Console.WriteLine(test);

        if(node.List == null)
        {
            Console.WriteLine("node is null {0}",node.Value);
        }

        StringBuilder result = new StringBuilder("(" + node.Value + ")");
        LinkedListNode<string> nodeP = node.Previous;

        while(nodeP != null)
        {
            result.Insert(0, nodeP.Value + " ");
            nodeP = nodeP.Previous;
        }

        node = node.Next;

        while (node != null)
        {
            result.Append(" " + node.Value);
            node = node.Next;
        }
        Console.WriteLine(result);
    }
}





