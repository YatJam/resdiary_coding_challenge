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
        };
    [Fact]
    public void TestGroupArrayElementsWithNoRemainder()
    {
        var input = new object[]{ 1, 2.0, true, "foo" };

        var result = GroupArray.GroupArrayElements(input, 2);

        Assert.Equal(2, result.Length);

        var expected = new object[][]
        {
            new object[]{ 1, 2.0 },
            new object[]{ true, "foo" }
        };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestGroupArrayElementsThrowsArgumentExceptionWithEmptyInput()
    {
        object[] input = Array.Empty<object>();

        var ex = Assert.Throws<ArgumentException>(() => GroupArray.GroupArrayElements(input, 3));

        Assert.Equal("Parameter has to contain at least one element (Parameter 'inputArray')", ex.Message);
    }
}
