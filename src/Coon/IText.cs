using System;

namespace Coon
{
    /// <summary>
    /// Text interface
    /// </summary>
    public interface IText : IComparable<IText>
    {
        string AsString();
    }
}