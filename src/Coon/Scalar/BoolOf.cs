using Coon.Text;

namespace Coon.Scalar
{
    public sealed class BoolOf : IScalar<bool>
    {
        private readonly IText _text;

        public BoolOf(string input)
            : this(new TextOf(input))
        { }

        public BoolOf(IText text)
        {
            _text = text;
        }
        
        public bool GetValue()
        {
            bool.TryParse(_text.AsString(), out bool result);
            return result;
        }
    }
}