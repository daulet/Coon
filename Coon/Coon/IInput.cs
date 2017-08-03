using System.IO;

namespace Coon
{
    public interface IInput
    {
        Stream GetStream();
    }
}