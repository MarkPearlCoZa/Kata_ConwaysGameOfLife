using System;

namespace GOL
{
    public class UI
    {
        public static void Main()
        {
            var myGame = new Game();
            //CreateGlider(myGame, new Location(1, 1));
            CreateBlinker(myGame, new Location(15, 1));
           // CreateGlider(myGame, new Location(15, 1));

            while (Console.ReadKey().KeyChar != 'q')
            {
                myGame.CurrentWorld = myGame.Evolve();
                Draw(myGame.CurrentWorld);
            }


        }

        private static void CreateGlider(Game myGame, Location location)
        {
            myGame.CurrentWorld.PlaceCell(new Location(location, 3, 1));
            myGame.CurrentWorld.PlaceCell(new Location(location, 1, 2));
            myGame.CurrentWorld.PlaceCell(new Location(location, 3, 2));
            myGame.CurrentWorld.PlaceCell(new Location(location, 2, 3));
            myGame.CurrentWorld.PlaceCell(new Location(location, 3, 3));
        }
        
        private static void CreateBlinker(Game myGame, Location location)
        {
            myGame.CurrentWorld.PlaceCell(new Location(location, 1, 1));
            myGame.CurrentWorld.PlaceCell(new Location(location, 1, 2));
            myGame.CurrentWorld.PlaceCell(new Location(location, 1, 3));            
        }

        private static void Draw(World world)
        {
            Console.Clear();
            foreach (var location in world.OccupiedLocations)
            {
                if ((location.X > -1) && (location.Y > -1))
                {
                    Console.SetCursorPosition(location.X, location.Y);
                    Console.WriteLine("X");
                }
            }

        }
    }
}
