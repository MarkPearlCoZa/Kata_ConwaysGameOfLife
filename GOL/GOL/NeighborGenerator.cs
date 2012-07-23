using System.Collections.Generic;

namespace GOL
{
    public class NeighborGenerator
    {
        public List<Location> GenerateNeighbors(Location location, List<Location> locationsToRemove )
        {
            var result = new List<Location>();

            for (int x = -1; x < 2; x++)
            {
                for (int y = -1; y < 2; y++)
                {
                    var proposedLocation = new Location(location.X + x, location.Y + y);
                    if (!locationsToRemove.Contains(proposedLocation))
                    {
                        result.Add(proposedLocation);                        
                    }
                }
            }                   
            return result;
        }
    }
}