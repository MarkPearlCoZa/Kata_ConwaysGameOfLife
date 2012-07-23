using NUnit.Framework;

namespace GOL.Tests
{
    [TestFixture]
    public class CellLifeEngineTests
    {
        [Test]
        public void LivingCellWithLessThanTwoNeighborsShouldDie()
        {
            var sut = new LivingCellLifeEngine();
            var result = sut.DetermineState(1);
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void LivingCellWithTwoNeighborsShouldLive()
        {
            var sut = new LivingCellLifeEngine();
            var result = sut.DetermineState(2);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void LivingCellWithThreeNeighborsShouldLive()
        {
            var sut = new LivingCellLifeEngine();
            var result = sut.DetermineState(3);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void LivingCellWithMoreThanThreeNeighborsShouldDie()
        {
            var sut = new LivingCellLifeEngine();
            var result = sut.DetermineState(4);
            Assert.That(result, Is.EqualTo(false));
        }
    }
}