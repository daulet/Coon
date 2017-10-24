using Coon.Scalar;

namespace Coon.Text
{
    public sealed class TextOf : IText
    {
        private readonly IScalar<string> _origin;

        public TextOf(string input)
            : this(new ScalarOf<string>(
                () => input)
            )
        { }

        private TextOf(IScalar<string> origin)
        {
            _origin = origin;
        }
        
        public string AsString()
        {
            return new IoCheckedScalar<string>(_origin).GetValue();
        }

        public int CompareTo(IText text)
        {
            throw new System.NotImplementedException();
        }
    }
}