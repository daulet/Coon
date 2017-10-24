using Coon.Scalar;
using System.Linq;
using Xunit;

namespace Coon.UnitTests.Scalar
{
    public class AndTests
    {
        [Fact]
        public void GetValue_AllTrue_True()
        {
            Assert.True(
                new And(
                    new True(),
                    new True(),
                    new True()
                ).GetValue());
        }

        [Fact]
        public void GetValue_OneFalse_False()
        {
            Assert.False(
                new And(
                    new True(),
                    new False(),
                    new True()
                ).GetValue());
        }

        [Fact]
        public void GetValue_AllFalse_False()
        {
            Assert.False(
                new And(
                    new False(),
                    new False(),
                    new False()
                ).GetValue());
        }

        [Fact]
        public void GetValue_EmptyEnumerable_True()
        {
            Assert.True(
                new And(
                    Enumerable.Empty<IScalar<bool>>()
                ).GetValue());
        }
    }
}
