namespace Coon
{
    public interface IScalar<out TValue>
    {
        TValue GetValue();
    }
}