using DemoCore;

namespace DemoTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var answer = LifeUniverseAndEverything.Answer();
        Assert.Equal(42, answer);   
    }
}
