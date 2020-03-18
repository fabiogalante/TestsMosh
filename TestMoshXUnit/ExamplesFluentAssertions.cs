using FluentAssertions;
using System.Collections;
using Xunit;

namespace TestMoshXUnit
{
    public class ExamplesFluentAssertions
    {

        [Fact]
        public void TestString()
        {
            string actual = "ABCDEFGHI";
            actual.Should().StartWith("AB").And.EndWith("HI").And.Contain("EF").And.HaveLength(9);
        }


        [Fact]
        public void TestIEnumerable()
        {
            IEnumerable numbers = new[] { 1, 2, 3 };
            numbers.Should().HaveCount(4, "because we thought we put four items in the collection");
        }
    }
}
