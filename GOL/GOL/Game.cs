namespace GOL
{
    public class Game
    {
        private readonly LivingCellLifeEngine _livingLifeEngine = new LivingCellLifeEngine();
        private readonly DeadCellLifeEngine _deadLifeEngine = new DeadCellLifeEngine();
        private readonly NeighborGenerator _neighborGenerator = new NeighborGenerator();

        public Game()
        {
            CurrentWorld = new World();
        }

        public World CurrentWorld
        {
            get;
            set;
        }

        public World Evolve()
        {
            var newWorld = new World();
            EvolveCells(newWorld);
            return newWorld;
        }

        private void EvolveDeadCellsAroundLivingCell(World newWorld, Location livingLocation)
        {
            var unoccupiedLocations = _neighborGenerator.GenerateNeighbors(livingLocation, CurrentWorld.OccupiedLocations);

            foreach (var subitems in unoccupiedLocations)
            {
                var unOccupiedNeighbors = CurrentWorld.GetNeighborsOfLocation(subitems);
                if (_deadLifeEngine.DetermineState(unOccupiedNeighbors)) newWorld.PlaceCell(subitems);
            }
        }

        private void EvolveCells(World newWorld)
        {
            foreach (var item in CurrentWorld.OccupiedLocations)
            {
                var neighbors = CurrentWorld.GetNeighborsOfLocation(item);
                if (_livingLifeEngine.DetermineState(neighbors)) newWorld.PlaceCell(item);
                EvolveDeadCellsAroundLivingCell(newWorld, item);
            }
        }
    }
}