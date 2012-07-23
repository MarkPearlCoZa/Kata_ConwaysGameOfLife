using System.Collections.Generic;
using NUnit.Framework;

namespace GOL.Tests
{
    public class NeighborGeneratorTests
    {
        [Test]
        public void ShouldGenerateAllNeighborsOfACell()
        {
            var sut = new NeighborGenerator();
            var theLocation = new Location(1, 1);
            var alreadyExistingItems = new List<Location>();
            alreadyExistingItems.Add(theLocation);                                          
            var result = sut.GenerateNeighbors(theLocation, alreadyExistingItems);
            Assert.That(result.Count, Is.EqualTo(8));
        }
    }
}