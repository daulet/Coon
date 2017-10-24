namespace Coon
{
    public interface IScalar<out T>
    {
        T GetValue();
    }
}