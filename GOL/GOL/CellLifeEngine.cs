using System;
using System.Collections.Generic;

namespace GOL
{
    public abstract class CellLifeEngine
    {
        private readonly Dictionary<int, bool> _mappedRules;

        protected CellLifeEngine(Dictionary<int, bool> mappedRules)
        {
            _mappedRules = mappedRules;            
        }

        public bool DetermineState(int neighbors)
        {
            try
            {
                return _mappedRules[neighbors];
            }
            catch (Exception)
            {
                return false;
            }            
        }
    }
}