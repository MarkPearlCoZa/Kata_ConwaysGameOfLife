using System.Collections.Generic;
using System.Linq;

namespace GOL
{
    public class World
    {

        private readonly NeighborGenerator _neighborGenerator;

        public List<Location> OccupiedLocations
        {
            get;
            private set;
        }

        public bool IsEmpty
        {
            get
            {
                return !OccupiedLocations.Any();
            }
        }

        public World()
        {
            _neighborGenerator = new NeighborGenerator();
            OccupiedLocations = new List<Location>();
        }

        public void PlaceCell(Location location)
        {
            if (!OccupiedLocations.Contains(location)) OccupiedLocations.Add(location);
        }

        public bool ContainsCellAt(Location location)
        {
            return OccupiedLocations.Contains(location);
        }

        public int GetNeighborsOfLocation(Location item)
        {
            var items = _neighborGenerator.GenerateNeighbors(item, new List<Location>())            
            return items.FindAll(x => OccupiedLocations.Contains(x)).Count;
        }
    }
}