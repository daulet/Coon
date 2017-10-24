using System.IO;

namespace Coon.IO
{
    public sealed class InputOf : IInput
    {
        private readonly FileInfo _fileInfo;

        public InputOf(FileInfo fileInfo)
        {
            _fileInfo = fileInfo;
        }
        
        public Stream GetStream()
        {
            return File.Open(_fileInfo.FullName, FileMode.Open);
        }
    }
}