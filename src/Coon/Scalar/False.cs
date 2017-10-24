namespace Coon.Scalar
{
    public sealed class False : IScalar<bool>
    {
        public bool GetValue()
        {
            return false;
        }
    }
}
