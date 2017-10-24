using System;
using System.IO;
using Coon.Func;
using Xunit;

namespace Coon.UnitTests.Func
{
    public class IoCheckedFuncTests
    {
        [Fact]
        public void Apply_ThrowsCheckedException_RethrowsSameException()
        {
            var expectedException = new IOException();
            try
            {
                new IoCheckedFunc<int, string>(
                    new FuncOf<int, string>(
                        x => throw expectedException)
                ).Apply(1);
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
                new IoCheckedFunc<int, string>(
                    new FuncOf<int, string>(
                        x => throw expectedInnerException)
                ).Apply(1);
            }
            catch (IOException ex)
            {
                Assert.Equal(expectedInnerException, ex.InnerException);
            }
        }
    }
}
