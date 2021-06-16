using System;
using Xunit;
using HelloWorld;

namespace XUnitTestProject1
{
    public class MessageBuilderTests
    {
        [Fact]
        public void HelloMessageTest()
        {
            string expectedValue = "Hello World";
            string actualValue;
            MessageBuilder builder = new MessageBuilder();
            actualValue = builder.BuildHelloMessage();
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void MessageTest()
        {
            string expectedValue = "Hello Fred";
            string actualValue;
            MessageBuilder builder = new MessageBuilder();
            actualValue = builder.BuildMessage("Hello {0}", "Fred");
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
