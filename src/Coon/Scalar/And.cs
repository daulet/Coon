using Coon.Iterable;
using System.Collections.Generic;
using System.Linq;

namespace Coon.Scalar
{
    public sealed class And : IScalar<bool>
    {
        private readonly IEnumerable<IScalar<bool>> _source;
        
        public And(params IScalar<bool>[] source)
            : this(new IterableOf<IScalar<bool>>(source))
        { }

        public And(IEnumerable<IScalar<bool>> source)
        {
            _source = source;
        }

        public bool GetValue()
        {
            return _source.All(scalar => scalar.GetValue());
        }
    }
}