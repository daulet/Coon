namespace Coon.Scalar
{
    public sealed class True : IScalar<bool>
    {
        public bool GetValue()
        {
            return true;
        }
    }
}
