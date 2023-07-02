namespace GroupArrayLibrary;

public static class GroupArray
{
    /* Returns the contents of the array divided into N equally sized arrays.
    Where the size of the original array cannot be divided equally by N, the final
    part has a length equal to the remainder.
    The method takes the following arguments:
    * input_array - array to be divided
    * num_of_parts - a positive integer indicating into how many parts the array should be split
    */
    public static T[][] GroupArrayElements<T>(this T[] inputArray, int numOfParts)
    {
        if (inputArray.Length == 0)
        {
            throw new ArgumentException(
                "Parameter has to contain at least one element", nameof(inputArray)
            );
        }

        var size = (int)Math.Ceiling((float)inputArray.Length / numOfParts);

        var groupedArray = new T[numOfParts][];

        for (var i = 0; i < numOfParts; i++) {
            groupedArray[i] = inputArray.Skip(i * size).Take(size).ToArray();
        }

        return groupedArray;
    }
}
