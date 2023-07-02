namespace GroupArrayLibraryTest;
using GroupArrayLibrary;

public class GroupArrayTest
{
    [Fact]
    public void TestGroupArrayElements()
    {
        object[] input = new object[]{1, 2, 3, 4};

        var result = GroupArray.GroupArrayElements(input);

        Assert.Equal(1, result.Length);
    }
}
