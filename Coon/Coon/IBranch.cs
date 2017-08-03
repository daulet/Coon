using System.Collections.Generic;
using System.IO;

namespace Coon
{
    public interface IBranch
    {
        IInput AsInput();
        
        IBranch GetParent();

        IList<IBranch> GetChildren();
    }
}