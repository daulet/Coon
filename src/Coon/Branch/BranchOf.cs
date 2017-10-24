using System.Collections.Generic;
using System.IO;

namespace Coon.Branch
{
    public class BranchOf : IBranch
    {
        private readonly string _filePath;

        public BranchOf(string filePath)
        {
            _filePath = filePath;
        }

        public IInput AsInput()
        {
            throw new System.NotImplementedException();
        }

        public IBranch GetParent()
        {
            throw new System.NotImplementedException();
        }

        public IList<IBranch> GetChildren()
        {
            throw new System.NotImplementedException();
        }
    }
}