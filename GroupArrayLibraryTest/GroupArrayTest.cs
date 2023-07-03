namespace GroupArrayLibraryTest;
using GroupArrayLibrary;

public class GroupArrayTest
{
    [Theory]
    [MemberData(nameof(Data))]
    public void TestGroupArrayElements<T>(T[] input, int numOfParts, T[][] expected)
    {
        var result = GroupArray.GroupArrayElements(input, numOfParts);

        Assert.Equal(numOfParts, result.Length);
        Assert.Equal(expected, result);
    }

    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            // Case when the input array can be equally divided
            new object[]
            {
                new object[]{ 1, 2.0, true, "foo" },
                2,
                new object[][]
                {
                    new object[]{ 1, 2.0 },
                    new object[]{ true, "foo" }
                }
            },
            // Case when there's a remainder
            new object[]
            {
                new object[]{ false, 0, "bar", 4.99D, -5 },
                3,
                new object[][]
                {
                    new object[]{ false, 0 },
                    new object[]{ "bar", 4.99D },
                    new object[]{ -5 }
                }
            },
            // Case when the remainder consists of more than 1 element
            new object[]
            {
                new int[]{ 1, 2, 3, 4, 5, 6, 7, 8 },
                3,
                new int[][]
                {
                    new int[]{ 1, 2, 3 },
                    new int[]{ 4, 5, 6 },
                    new int[]{ 7, 8 }
                }
            },
            // Case when numOfParts is higher than the length of the input array
            new object[]
            {
                new int[]{ 1, 2 },
                3,
                new int[][]
                {
                    new int[]{ 1 },
                    new int[]{ 2 },
                    new int[]{}
                }
            },
            // Case when the inputArray is empty
            new object[]
            {
                Array.Empty<object>(),
                2,
                new object[][]
                {
                    new object[]{},
                    new object[]{}
                }
            },
        };

    [Fact]
    public void TestGroupArrayElementsCanBeCalledAsExtensionMethod()
    {
        var input = new object[]{ 1, 2.0, true, "foo" };

        var result = input.GroupArrayElements(2);

        Assert.Equal(2, result.Length);

        var expected = new object[][]
        {
            new object[]{ 1, 2.0 },
            new object[]{ true, "foo" }
        };
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-4)]
    public void TestGroupArrayElementsThrowsArgumentExceptionWhenNumOfPartsIsNotPositive(int numOfParts)
    {
        var input = new string[]{ "foo", "bar", "baz" };

        var ex = Assert.Throws<ArgumentException>(() => GroupArray.GroupArrayElements(input, numOfParts));

        Assert.Equal("Parameter has to be a positive integer (Parameter 'numOfParts')", ex.Message);
    }
}
