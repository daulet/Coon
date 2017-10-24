using Coon.Text;
using Xunit;

namespace Coon.UnitTests.Text
{
    public class TextOfTests
    {
        [Fact]
        public void AsString_ValidString_SameString()
        {
            Assert.Equal("Hello World!", new TextOf("Hello World!").AsString());
        }
    }
}
