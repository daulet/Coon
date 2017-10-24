namespace Coon
{
    public interface IFunc<in TInput, out TOutput>
    {
        TOutput Apply(TInput input);
    }
}