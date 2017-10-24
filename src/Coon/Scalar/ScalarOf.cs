using System;

namespace Coon.Scalar
{
    public sealed class ScalarOf<T> : IScalar<T>
    {
        private readonly Func<T> _func;

        public ScalarOf(Func<T> func)
        {
            _func = func;
        }

        public T GetValue()
        {
            return _func.Invoke();
        }
    }
}
