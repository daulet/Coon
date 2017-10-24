using Coon.Scalar;
using System;
using System.IO;
using Xunit;

namespace Coon.UnitTests.Scalar
{
    public class IoCheckedScalarTests
    {
        [Fact]
        public void Apply_ThrowsCheckedException_RethrowsSameException()
        {
            var expectedException = new IOException();
            try
            {
                new IoCheckedScalar<int>(
                    new ScalarOf<int>(
                        () => throw expectedException)
                ).GetValue();
            }
            catch (IOException ex)
            {
                Assert.Equal(expectedException, ex);
            }
        }

        [Fact]
        public void Apply_ThrowsUncheckedException_RethrowsCheckedException()
        {
            var expectedInnerException = new Exception();
            try
            {
                new IoCheckedScalar<int>(
                    new ScalarOf<int>(
                        () => throw expectedInnerException)
                ).GetValue();
            }
            catch (IOException ex)
            {
                Assert.Equal(expectedInnerException, ex.InnerException);
            }
        }
    }
}
