using System.Collections.Generic;

namespace Coon
{
    public interface IBranch
    {
        IInput AsInput();
        
        IBranch GetParent();

        IList<IBranch> GetChildren();
    }
}