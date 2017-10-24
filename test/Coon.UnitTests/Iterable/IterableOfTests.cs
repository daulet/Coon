using Coon.Iterable;
using Moq;
using System;
using Xunit;

namespace Coon.UnitTests.Iterable
{
    public class IterableOfTests
    {
        [Fact]
        public void Constructor_DoesNotEnumerate()
        {
            // Arrange
            var mock = new Mock<IScalar<object>>();
            mock.Setup(x => x.GetValue())
                .Throws<NotImplementedException>();
            // Act
            var iterable = new IterableOf<object>(mock.Object, mock.Object);
            // Assert
            Assert.NotNull(iterable);
        }
    }
}
