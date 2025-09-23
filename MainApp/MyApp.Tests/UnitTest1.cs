using Xunit;

namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Addition_Works()
    {
        int a = 2, b = 3;
        int result = a + b;
        Assert.Equal(5, result);
    }

    [Fact]
    public void Failing_Test()
    {
        int x = 10, y = 5;
        Assert.Equal(20, x + y); // ❌ This will fail
    }
}
