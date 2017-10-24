using Coon.Func;

namespace Coon.Scalar
{
    public sealed class IoCheckedScalar<TValue> : IScalar<TValue>
    {
        private readonly IScalar<TValue> _origin;

        public IoCheckedScalar(IScalar<TValue> origin)
        {
            _origin = origin;
        }

        public TValue GetValue()
        {
            return new IoCheckedFunc<IScalar<TValue>, TValue>(
                new FuncOf<IScalar<TValue>, TValue>(
                    x => x.GetValue()
                )
            ).Apply(_origin);
        }
    }
}
