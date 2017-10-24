using System;

namespace Coon.Func
{
    public sealed class FuncOf<TInput, TOutput> : IFunc<TInput, TOutput>
    {
        private readonly Func<TInput, TOutput> _function;

        public FuncOf(Func<TInput, TOutput> function)
        {
            _function = function;
        }

        public TOutput Apply(TInput input)
        {
            return _function(input);
        }
    }
}
