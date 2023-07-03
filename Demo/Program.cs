using GroupArrayLibrary;

class Program
{
    static void Main(string[] args)
    {
        string? userInputElements = string.Empty;

        while(string.IsNullOrEmpty(userInputElements))
        {
            Console.WriteLine("Please enter array elements separated by spaces, e.g `1 2 3 foo`");
            userInputElements = Console.ReadLine();
        }

        string[] inputArray = userInputElements.Split(" ");

        string? userInputNumOfParts = string.Empty;

        while(string.IsNullOrEmpty(userInputNumOfParts))
        {
            Console.WriteLine("How many parts should the array be divided into?");
            userInputNumOfParts = Console.ReadLine();
        }

        var result = GroupArray.GroupArrayElements(inputArray, Int32.Parse(userInputNumOfParts));

        foreach (var part in result)
        {
            Console.WriteLine("[{0}]", string.Join(", ", part));
        }
    }
}

