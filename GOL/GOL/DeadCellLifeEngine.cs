using System.Collections.Generic;

namespace GOL
{
    public class DeadCellLifeEngine : CellLifeEngine
    {
        public DeadCellLifeEngine() : base(new Dictionary<int, bool>{{3, true}})
        {            
        }                
    }
}