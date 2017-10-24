namespace Coon
{
    /// <summary>
    /// Text interface
    /// </summary>
    public interface IText
    {
        string AsString();

        int CompareTo(IText text);
    }
}