using System;
using System.IO;

namespace Coon.Func
{
    public sealed class IoCheckedFunc<TInput, TOutput> : IFunc<TInput, TOutput>
    {
        private readonly IFunc<TInput, TOutput> _function;

        public IoCheckedFunc(IFunc<TInput, TOutput> function)
        {
            _function = function;
        }

        public TOutput Apply(TInput input)
        {
            try
            {
                return _function.Apply(input);
            }
            catch (IOException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new IOException(string.Empty, ex);
            }
        }
    }
}
