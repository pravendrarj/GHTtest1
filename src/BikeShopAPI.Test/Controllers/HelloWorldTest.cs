using Xunit;

public class HelloWorldTest
{
    [Fact]
    public void HelloWorld_ReturnsExpectedMessage()
    {
        var controller = new HelloWorldController();
        var result = controller.GetMessage();
        Assert.Equal("Hello, World!", result);
    }
}