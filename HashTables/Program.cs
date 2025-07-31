

//create a new dict of strings, with string keys.
Dictionary<string, string> openWith = new Dictionary<string, string>();


//add some elements to the dict
openWith.Add("txt", "notepad.exe");
openWith.Add("bmp", "paint.exe");
openWith.Add("dib", "paint.exe");
openWith.Add("rtf", "wordpad.exe");


try
{
    openWith.Add("txt", "winword.exe");
}
catch (ArgumentException)
{
    Console.WriteLine("an element with key already exists");
}



Console.WriteLine("for key =  {0} value = {1}","txt", openWith["txt"]);

//the index can be used to change the value associated with a key.
openWith["rtf"] = "winword.exe";
Console.WriteLine("for key =  {0} value = {1}", "rtf", openWith["rtf"]);


try
{
    Console.WriteLine("For key = \"tif\", value = {0}.",
        openWith["tif"]);
}
catch (KeyNotFoundException)
{
    Console.WriteLine("Key = \"tif\" is not found.");
}


// When a program often has to try keys that turn out not to
// be in the dictionary, TryGetValue can be a more efficient
// way to retrieve values.
string value = "";

if (openWith.TryGetValue("tif", out value))
{
    Console.WriteLine("For key = \"tif\", value = {0}.", value);
}
else
{
    Console.WriteLine("Key = \"tif\" is not found.");
}



if (!openWith.ContainsKey("ht"))
{
    openWith.Add("ht", "hypertrm.exe");
    Console.WriteLine("value added ht {0}", openWith["ht"]);
}

//when you use foreach to enumarete dictionary elements, the elements are retrieved as KeyValuePair objects
foreach (KeyValuePair<string,string> kvp in openWith)
{
    Console.WriteLine("key = {0} , value = {1}",kvp.Key, kvp.Value);
}


//to get the keys alone , use the keys prop
Dictionary<string, string>.KeyCollection keyColl = openWith.Keys;

//the elements of the KeyCollection are strongly typed with the type that was specified for dictionary keys

foreach(string k in keyColl)
{
    Console.WriteLine(k);
}


//use te remove method to remove a key/value pair.
openWith.Remove("ht");

if (!openWith.ContainsKey("ht"))
{
    Console.WriteLine("Key is not found.");
}


openWith.Clear();
