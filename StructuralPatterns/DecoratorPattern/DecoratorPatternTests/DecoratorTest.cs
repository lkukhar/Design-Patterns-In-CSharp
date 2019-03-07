using DecoratorPatternImplementation;
using Xunit;

namespace DecoratorPatternTests
{
    public class DecoratorTest
    {
        [Fact]
        public void Creates_Red_Lexus()
        {
            Lexus lexus = new Lexus();
            RedCarDecorator redCarDecorator = new RedCarDecorator(lexus);
            Assert.Equal("Lexus is being driven.", redCarDecorator.Drive());
            Assert.Equal("Red", lexus.Color);
        }

        [Fact]
        public void Creates_Red_BMW()
        {
            BMW bmw = new BMW();
            RedCarDecorator redCarDecorator = new RedCarDecorator(bmw);
            Assert.Equal("BMW is being driven.", redCarDecorator.Drive());
            Assert.Equal("Red", bmw.Color);
        }
    }
}
