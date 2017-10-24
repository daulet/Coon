using Coon.Scalar;
using Xunit;

namespace Coon.UnitTests.Scalar
{
    public class BoolOfTests
    {
        [Fact]
        public void GetValue_TrueString_True()
        {
            Assert.True(new BoolOf("True").GetValue());
        }

        [Fact]
        public void GetValue_FalseString_False()
        {
            Assert.False(new BoolOf("false").GetValue());
        }

        [Fact]
        public void GetValue_NonBooleanString_False()
        {
            Assert.False(new BoolOf("Not a boolean string").GetValue());
        }
    }
}
