using FluentAssertions;
using System;
using TestMoshClassLibrary;
using Xunit;

namespace TestMoshXUnit
{


    //Test method Void
    public class ErrorLoggerTests
    {

        [Fact]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();

            logger.Log("a");

            logger.LastError.Should().Be("a");

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            var logger = new ErrorLogger();

            Action act = () => logger.Log(error);

            act.Should().Throw<ArgumentNullException>();
            Assert.Throws<ArgumentNullException>(() => logger.Log(error));


        }
    }
}
