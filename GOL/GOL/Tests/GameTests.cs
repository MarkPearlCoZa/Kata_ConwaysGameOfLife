using NUnit.Framework;

namespace GOL.Tests
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void EmptyWorldWithNoCellsShouldGenerateEmptyWorldWithNoCellsAfterTick()
        {
            var sut = new Game();
            sut.CurrentWorld = new World();
            var result = sut.Evolve();
            Assert.That(result.IsEmpty, Is.EqualTo(true));
        }

        [Test]
        public void WorldWithOneCellShouldGenerateEmptyWorldAfterTick()
        {
            var sut = new Game();
            var location = new Location();
            sut.CurrentWorld.PlaceCell(location);
            World result = sut.Evolve();
            Assert.That(result.IsEmpty, Is.EqualTo(true));
        }

        [Test]
        public void WorldWithTwoCellsShouldGenerateEmptyWorldAfterTick()
        {
            var sut = new Game();
            var location1 = new Location(1, 1);
            var location2 = new Location(1, 2);
            sut.CurrentWorld.PlaceCell(location1);
            sut.CurrentWorld.PlaceCell(location2);
            World result = sut.Evolve();
            Assert.That(result.IsEmpty, Is.EqualTo(true));
        }

        [Test]
        public void WorldWithThreeCellsNextToEachotherShouldGenerateWorldWithThreeCellAfterTick()
        {
            var sut = new Game();
            var location1 = new Location(1, 1);
            var location2 = new Location(1, 2);
            var location3 = new Location(1, 3);
            
            var location4 = new Location(0, 2);
            var location5 = new Location(2, 2);

            sut.CurrentWorld.PlaceCell(location1);
            sut.CurrentWorld.PlaceCell(location2);
            sut.CurrentWorld.PlaceCell(location3);

            World result = sut.Evolve();
            Assert.That(result.ContainsCellAt(location1), Is.EqualTo(false));
            Assert.That(result.ContainsCellAt(location2), Is.EqualTo(true));
            Assert.That(result.ContainsCellAt(location3), Is.EqualTo(false));
            Assert.That(result.ContainsCellAt(location4), Is.EqualTo(true));
            Assert.That(result.ContainsCellAt(location5), Is.EqualTo(true));
        }
    }
}