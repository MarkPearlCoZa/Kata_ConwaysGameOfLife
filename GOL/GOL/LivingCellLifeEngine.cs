using System.Collections.Generic;

namespace GOL
{    
    public class LivingCellLifeEngine : CellLifeEngine
    {
        public LivingCellLifeEngine() : base(new Dictionary<int, bool> { { 2, true }, { 3, true } })
        {
        }
    }
}