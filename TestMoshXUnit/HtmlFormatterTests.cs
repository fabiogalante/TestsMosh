using TestMoshClassLibrary;
using Xunit;

namespace TestMoshXUnit
{
    public class HtmlFormatterTests
    {
        [Fact]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormater();

            var result = formatter.FormatAsBold("abc");

            Assert.Contains("abc", result);

            Assert.StartsWith("<strong>", result);

            Assert.EndsWith("</strong>", result);
        }
    }
}
