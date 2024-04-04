using Playground;
using Xunit;

namespace PlaygroundTests;

public class Net8ExamplesTests
{
    [Fact]
    public void FindFirstHexChar_TestResults()
    {
        Assert.Equal(-1, Net8Examples.FindFirstHexChar("hijk"));
        Assert.Equal(0, Net8Examples.FindFirstHexChar("abcd"));
        Assert.Equal(4, Net8Examples.FindFirstHexChar("hijk0abc"));
    }
}