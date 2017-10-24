using System;
using System.Globalization;

namespace Coon.Text
{
    public sealed class UpperText : IText
    {
        private readonly IText _text;

        public UpperText(IText text)
        {
            _text = text;
        }

        public string AsString()
        {
            return _text.AsString().ToLower(CultureInfo.InvariantCulture);
        }

        public int CompareTo(IText text)
        {
            throw new NotImplementedException();
        }
    }
}