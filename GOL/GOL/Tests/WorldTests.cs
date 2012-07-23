using NUnit.Framework;

namespace GOL.Tests
{
    [TestFixture]
    public class WorldTests
    {
        [Test]
        public void ShouldNotBeEmptyAfterCellIsPlacedInWorld()
        {
            var sut = new World();
            sut.PlaceCell(new Location());
            Assert.That(sut.IsEmpty, Is.EqualTo(false));
        }

        [Test]
        public void ShouldBeEmptyIfANewWorldIsCreated()
        {
            var sut = new World();
            Assert.That(sut.IsEmpty, Is.EqualTo(true));
        }

        [Test]
        public void ShouldGetNeighborsOfCell()
        {
            var sut = new World();
            var loc = new Location(1, 1);
            sut.PlaceCell(loc);
            sut.PlaceCell(new Location(1, 2));
            var result = sut.GetNeighborsOfLocation(loc);
            Assert.That(result, Is.EqualTo(1));
        }

    }
}
