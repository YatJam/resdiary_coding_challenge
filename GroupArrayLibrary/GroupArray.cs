namespace GroupArrayLibrary;

public static class GroupArray
{
    /* Returns the contents of the array divided into N equally sized arrays.
    Where the size of the original array cannot be divided equally by N, the final
    part has a length equal to the remainder.
    The method takes the following arguments:
    * input_array - array to be divided
    * N - a positive integer indicating into how many parts the array should be split
    */
    public static object[][] GroupArrayElements(this object[] input_array, int n)
    {
        return new object[1][]{ input_array };
    }
}
