using Coon.Scalar;
using System.Collections;
using System.Collections.Generic;

namespace Coon.Iterable
{
    public class IterableOf<T> : IEnumerable<T>
    {
        private readonly IScalar<IEnumerator<T>> _source;

        public IterableOf(params T[] source)
            : this(new ScalarOf<IEnumerator<T>>(() =>
                    new List<T>(source).GetEnumerator()))
        { }

        private IterableOf(IScalar<IEnumerator<T>> source)
        {
            _source = source;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            return _source.GetValue();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _source.GetValue();
        }
    }
}