using GroupArrayLibrary;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a list of elements separated by spaces, e.g `1 2 3 abc");
        string user_input = Console.ReadLine();
        string[] elements = user_input.Split(" ");

        var result = GroupArray.GroupArrayElements(elements, 2);
        Console.WriteLine(result.Length);
    }
}

