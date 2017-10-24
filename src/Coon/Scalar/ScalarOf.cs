using System;

namespace Coon.Scalar
{
    public sealed class ScalarOf<TValue> : IScalar<TValue>
    {
        private readonly Func<TValue> _function;

        public ScalarOf(Func<TValue> function)
        {
            _function = function;
        }

        public TValue GetValue()
        {
            return _function.Invoke();
        }
    }
}
